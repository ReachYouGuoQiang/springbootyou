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
    public partial class FrmJudge : Form
    {
        public Employee emp;

        public FrmJudge()
        {
            InitializeComponent();
        }
        #region 将数据绑定到窗体上
        public void Bid()
        {
            this.txtName.Text = emp.Name;
            this.txtPingFen.Text = emp.Score.ToString();
            this.txtPingJia.Text = emp.Content;
        }
        #endregion

        #region 评分窗体的加载事件
        private void FrmJudge_Load(object sender, EventArgs e)
        {
            Bid();
        }
        #endregion

        #region 评分按钮的点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            emp.Name = this.txtName.Text;
            emp.Content = this.txtPingJia.Text;
            emp.Score = int.Parse(this.txtPingFen.Text);
            this.Close();
        }
        #endregion

        #region 保存的代码
        public void Cun()
        {
            
        }
        #endregion


    }
}
