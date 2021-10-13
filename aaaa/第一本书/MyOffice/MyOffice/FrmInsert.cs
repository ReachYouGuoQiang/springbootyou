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
    public partial class frminsert : Form
    {
        public List<S> list;
        public frminsert()
        {
            InitializeComponent();
        }

        #region 新增按钮的点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            
            //string id = this.txtid.Text;
            //foreach (S s in this.list)
            //{
            //    if (s.Id == id)
            //    {
            //        MessageBox.Show("工号已存在");
            //    }
            //}

            //string name = this.txtName.Text;
            //int age = int.Parse(this.txtAge.Text);
            //string sex = this.cboSex.SelectedItem.ToString();
            //S se = new S();
            //se.Id = id;
            //se.Name = name;
            //se.Age = age;
            //se.Sex = sex;

            //this.list.Add(se);
            //this.Close();
        }
        #endregion

        
        
    }
}
