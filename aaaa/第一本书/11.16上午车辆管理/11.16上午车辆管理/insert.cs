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
    public partial class insert : Form
    {
        public List<Car> list;
        public insert()
        {
            InitializeComponent();
        }

        #region 新增的点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.tetId.Text;
            string name = this.tetNames.Text;
            double price = double.Parse(this.tetPrice.Text);
            string YongTu = this.cboYongTu.SelectedItem.ToString();

            Car c = new Car();
            c.ID = id;
            c.Names = name;
            c.Price = price;
            c.YongTu = YongTu;
            this.list.Add(c);
            this.Close();

        }
        #endregion
    }
}
