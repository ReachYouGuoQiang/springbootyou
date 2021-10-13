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
    public partial class BianMaCeshi : Form
    {
        List<Job> list = new List<Job>();
        public BianMaCeshi()
        {
            InitializeComponent();
        }

        #region 加载
        private void BianMaCeshi_Load(object sender, EventArgs e)
        {
            init();
        }
        #endregion

        #region 初始化
        private void init()
        {
            JobCade cade = new JobCade();
            cade.Type = "达瓦大";
            cade.Names = "达瓦";
            cade.Description = "Dwad";
            list.Add(cade);
            JobTest test = new JobTest();
            test.Type = "达瓦大";
            test.Names = "达瓦";
            test.Description = "Dwad";
            list.Add(test);
            this.dgvShow.DataSource = list;
            //JobCade cade = new JobCade();
            //cade.Type = "编码";
            //cade.Names = "还是编码";
            //cade.Description = "就是编码";
            //list.Add(cade);
            //JobTest test = new JobTest();
            //test.Type = "测试";
            //test.Names = "还是测试";
            //test.Description = "就是测试";
            //list.Add(test);

            //this.dgvShow.DataSource = list;
        }
        #endregion

        #region 执行的点击事假
        private void 执行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvShow.SelectedRows.Count == 0)
            {
                return;
            }
            int index = this.dgvShow.SelectedRows[0].Index;
            this.list[index].Execute();
            //if (this.dgvShow.SelectedRows.Count == 0)
            //{
            //    return;
            //}
            //int index = this.dgvShow.SelectedRows[0].Index;
            //this.list[index].Execute();
        }
        #endregion

        #region 查看回家清空
        private void 完成情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvShow.SelectedRows.Count == 0)
            {
                return;
            }
            int index = this.dgvShow.SelectedRows[0].Index;
            MessageBox.Show(this.list[index].Show());
            //if (this.dgvShow.SelectedRows.Count == 0)
            //{
            //    return;
            //}
            //int index = this.dgvShow.SelectedRows[0].Index;
            //MessageBox.Show(this.list[index].Show());
        }
        #endregion
        
        
    }
}
