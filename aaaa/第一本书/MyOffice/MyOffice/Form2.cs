using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<S> list = new List<S>();
        Dictionary<string, Record> rs = new Dictionary<string,Record>();
        #region 初始化数据
        private void Init()
        {

            S s1 = new S() { Id = "1001", Age = 22, Name = "张三", Sex = "男" };
            list.Add(s1);
            S s2 = new S() { Id = "1002", Age = 32, Name = "张五", Sex = "女" };
            list.Add(s2);
            S s3 = new S() { Id = "1003", Age = 42, Name = "张四", Sex = "男" };
            list.Add(s3);
        }
        #endregion

        #region 窗体的加载事件
        private void Form2_Load(object sender, EventArgs e)
        {
            Init();

            BidDgv();
        }
        #endregion

        #region 绑定数据DGV
        private void BidDgv()
        {
            this.dgvShow.DataSource = new BindingList<S>(list);
        }
        #endregion

        #region 查询按钮
        private void button1_Click(object sender, EventArgs e)
        {

            string id = this.tetId.Text;
            List<S> searchaList = new List<S>();
            //遍历
            foreach (S se in list)
            {
                //如果某个Se对象的Id属性包含要查找的id值 那就算一个
                if (se.Id.IndexOf(id) != -1)
                {
                    //此时的se就是需要展示的对象之一
                    searchaList.Add(se);
                }
            }
            this.dgvShow.DataSource = new BindingList<S>(searchaList);
        }
        #endregion

        #region 删除的点击事件
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("是否删除?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            //获取选中的se对象的工号
            string id = this.dgvShow.CurrentRow.Cells[0].Value.ToString();
            //根据工号获取se对象
            foreach (S s in list)
            {
                if (s.Id == id)
                {
                    //根据se对象删除
                    list.Remove(s);
                    break;
                }
            }
            this.dgvShow.DataSource = new BindingList<S>(list);
        }
        #endregion

        #region 新增的点击事件
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frminsert insert = new frminsert();
            insert.list = this.list;
            insert.ShowDialog();
            this.BidDgv();
        }
        #endregion

        #region 签到的点击事件
        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断
            if (this.dgvShow.SelectedRows.Count == 0)
            {
                return;
            }
            //查看是否已经签到
            string id = this.dgvShow.CurrentRow.Cells["ID"].Value.ToString();
            foreach (string k in rs.Keys)
            {
                if (k == id)
                {
                    MessageBox.Show("您已经签到过了!");
                    return;
                }
            }

            //开始进行签到
            Record r = new Record();
            r.id = id;
            r.Name = this.dgvShow.CurrentRow.Cells["Names"].Value.ToString();
            r.SignIn = DateTime.Now;
            this.rs.Add(id, r);
            MessageBox.Show("签到成功");
        }
        #endregion

        #region 签退的点击事件
        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断
            if (this.dgvShow.SelectedRows.Count == 0)
            {
                return;
            }

            //开始签退
            //判断是否已经签到,未签到提示签到
            string id = this.dgvShow.CurrentRow.Cells["ID"].Value.ToString();
            foreach (string k in this.rs.Keys)
            {
                //加上if如果找到签到记录
                //已签到 进行签退操作
                if (k == id)
                {
                    //执行签退 找到这个员工的签到记录 把记录里的签退属性进行赋值 结束
                    Record r = this.rs[id];
                    r.SignOut = DateTime.Now;
                    MessageBox.Show("签退成功");
                    return;
                }
            }

            MessageBox.Show("您尚未签到，无法进行签退");
        }
        #endregion

        #region 打卡记录
        private void 打卡记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.rs = this.rs;
            frm.Show();
        }
        #endregion
        

        
        
        
        
    }
}
