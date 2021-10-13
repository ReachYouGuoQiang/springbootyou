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
    public partial class frmshow : Form
    {
        Employee[] es = new Employee[1];

        public frmshow()
        {
            InitializeComponent();
        }
        public void Init()
        {
            es[0] = new Employee();
            es[0].id = 1001;
            es[0].Name = "达瓦";
            es[0].Age = 15;
        }
        #region 加载窗体
        private void FrmShow_Load(object sender, EventArgs e)
        {
            Init();
            BidLv();
        }
        #endregion

        public void BidLv()
        {
            this.lvSHow.Items.Clear();
            foreach (Employee c in es)
            {
                ListViewItem item = new ListViewItem(c.id.ToString());
                item.SubItems.Add(c.Name);
                item.SubItems.Add(c.Age.ToString());
                item.SubItems.Add(c.Content);
                item.SubItems.Add(c.Score.ToString());
                this.lvSHow.Items.Add(item);
            }
        }

        #region 双击事件
        private void lvSHow_DoubleClick(object sender, EventArgs e)
        {
            //判断是否选中一行
            if (this.lvSHow.SelectedItems.Count == 0)
            {
                return;
            }

            int index=this.lvSHow.SelectedItems[0].Index;
            FrmJudge frm = new FrmJudge();
            frm.emp = es[index];
            frm.ShowDialog();
            this.BidLv();


        }
        #endregion
        

    }
}
