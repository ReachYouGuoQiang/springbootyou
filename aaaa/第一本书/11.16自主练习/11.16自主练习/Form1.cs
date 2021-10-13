using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._16自主练习
{
    public partial class Form1 : Form
    {
        List<Cars> list = new List<Cars>();
        public Form1()
        {
            InitializeComponent();
        }

        #region 初始化数据
        public void Init()
        { 
            Cars C1=new Cars(){Names="免得你们", ID="苏C88878", Price=11.11, Type="客车"};
            list.Add(C1);
            Cars C2 = new Cars() { Names = "免得你们", ID = "苏C89888", Price = 11.11, Type = "客车" };
            list.Add(C2);
            Cars C3 = new Cars() { Names = "免得你们", ID = "苏C10888", Price = 11.11, Type = "客车" };
            list.Add(C3);
        }
        #endregion

        #region 绑定Dgv
        public void BidDgv()
        {
            this.dgvShow.DataSource = new BindingList<Cars>(list);
        }
        #endregion

        #region 加载窗体
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            BidDgv();
        }
        #endregion

        #region 查询的点击事件以及代码
        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.tetID.Text;

            List<Cars> search = new List<Cars>();
            //获取id根据id来查询
            foreach (Cars cs in list)
            {
                if (cs.ID.IndexOf(id) != -1)
                {
                    search.Add(cs);
                }
            }
            this.dgvShow.DataSource = new BindingList<Cars>(search);
        }
        #endregion

        #region 删除的点击事件
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否删除","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }

            string id = this.dgvShow.CurrentRow.Cells[0].Value.ToString();
            foreach (Cars cs in list)
            {
                if (cs.ID == id)
                {
                    list.Remove(cs);
                    break;
                }
            }
            this.dgvShow.DataSource = new BindingList<Cars>(list);
        }
        #endregion
        
    }
}
