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
    public partial class FrmCade : Form
    {
        public JobCade cade;
        public FrmCade()
        {
            InitializeComponent();
        }

        #region 提交的点击事件
        private void btnTiJiao_Click(object sender, EventArgs e)
        {
            cade.CodeLines = int.Parse(this.tetHang.Text);
            cade.Questions = int.Parse(this.tetWenTi.Text);
            cade.Days = int.Parse(this.tetDay.Text);
            this.Close();
            //cade.CodeLines = int.Parse(this.tetHang.Text);
            //cade.Questions = int.Parse(this.tetWenTi.Text);
            //cade.Days = int.Parse(this.tetDay.Text);
            //this.Close();
        }
        #endregion
        

    }
}
