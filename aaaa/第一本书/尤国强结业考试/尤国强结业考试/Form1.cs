using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 尤国强结业考试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Employee> list = new List<Employee>();
        public void Init()
        {
            SE se = new SE();
            se.Names = "艾边成";
            se.Age = 20;
            se.ID = "1001";
            se.Sex = "男";
            se.Popularity = "99";
            list.Add(se);
            SE se1 = new SE();
            se1.Names = "乔伊";
            se1.Age = 30;
            se1.ID = "1002";
            se1.Sex = "女";
            se1.Popularity = "88";
            list.Add(se1);
            PM p = new PM();
            p.Names = "盖子";
            p.Age = 50;
            p.Sex = "男";
            p.ID = "1003";
            p.Experience = "20";
            list.Add(p);
        }


        #region 绑定SE
        public void BidLv()
        {
            foreach (Employee s in list)
            {
                ListViewItem item=new ListViewItem(s.ID);
                item.SubItems.Add(s.Names);
                item.SubItems.Add(s.Age.ToString());
                item.SubItems.Add(s.Sex);
                this.Lvshow.Items.Add(item);
            }
        }
        #endregion

        

        #region 窗体的加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            BidLv();
        }
        #endregion

        #region 打招呼的点击事件
        private void 打招呼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Lvshow.SelectedItems.Count == 0)
            {
                return;
            }
            
                string index = this.Lvshow.SelectedItems[0].SubItems[0].Text.ToString();
                foreach (Employee i in list)
                {
                    if(index==i.ID)
                    {
                        i.SayHi();
                    }
                }
        }
        #endregion
        
        
    }
}
