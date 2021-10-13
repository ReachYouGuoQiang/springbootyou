using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._16上午车辆管理
{
    public partial class Form1 : Form
    {
        List<Car> list = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        #region 初始化数据
        public void ChuShi()
        {
            //创建对象存进去
            Car c1 = new Car() { Names = "五菱", ID = "苏C 445555", Price = 99999.9, YongTu = "货车" };
            //添加到泛型集合里
            list.Add(c1);
            //创建对象存进去
            Car c2 = new Car() { Names = "奥迪A100", ID = "苏C456465", YongTu = "客车", Price = 88.88 };
            //添加到泛型集合里
            list.Add(c2);
            //创建对象存进去
            Car c3 = new Car() { Names = "奥迪A100", ID = "苏C111111", YongTu = "客车", Price = 88.88 };
            //添加到泛型集合里
            list.Add(c3);
            //创建对象存进去
            Car c4 = new Car() { Names = "奥迪A100", ID = "苏C333333", YongTu = "客车", Price = 88.88 };
            //添加到泛型集合里
            list.Add(c4);
        }
        #endregion

        #region 绑定Dgv
        public void BidDgv()
        {
            //绑定数据源固定写法
            this.dgvShow.DataSource = new BindingList<Car>(list);
        }
        #endregion

        #region 窗体的加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            ChuShi();
            BidDgv();
        }
        #endregion

        #region 查询的代码
        public void select()
        {
            //获取到文本框的值
            string id = this.tetID.Text;
            //创建一个集合来负责遍历
            List<Car> searchar = new List<Car>();
            //遍历
            foreach (Car ce in list)
            {
                if (ce.ID.IndexOf(id) != -1)
                {
                    //此时的ce就是要展示的对象
                    searchar.Add(ce);
                }
            }
            this.dgvShow.DataSource = new BindingList<Car>(searchar);
            
        }
        #endregion

        #region 查询的点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            select();
        }
        #endregion

        #region 删除的点击事件
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否删除?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
            //获取当前id的值
            string id = this.dgvShow.CurrentRow.Cells[0].Value.ToString();
            //获取员工对象
            foreach (Car C in list)
            {
                if (C.ID == id)
                {
                    //根据C对象删除
                    list.Remove(C);
                    break;
                }
            }
            this.dgvShow.DataSource = new BindingList<Car>(list);
        }
        #endregion

        #region 新增的点击事件
        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insert insert = new insert();
            insert.list = this.list;
            insert.ShowDialog();
            this.BidDgv();
        }
        #endregion
    }
}
