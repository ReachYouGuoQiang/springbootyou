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
    public partial class Form3 : Form
    {
        public Dictionary<string, Record> rs;
        public Form3()
        {
            InitializeComponent();
        }

        #region 窗体的加载事件
        private void Form3_Load(object sender, EventArgs e)
        {
            this.dgvshow.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = rs.Values;
            this.dgvshow.DataSource = bs;

            this.label1.Text = string.Format("共有{0}条数据", this.rs.Count);
        }
        #endregion
        

    }
}
