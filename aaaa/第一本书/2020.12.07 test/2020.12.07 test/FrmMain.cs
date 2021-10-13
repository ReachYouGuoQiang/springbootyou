using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020._12._07_test
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// 初始化员工集合
        /// </summary>
        List<Employee> list = new List<Employee>()
        {
            new SE(20, 1001, "艾边成", "男", 100),
            new SE(30, 1002, "乔伊", "女", 200),
            new PM(50, 1003, "盖茨", "男", 10)
        };

        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Bind();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void Bind() 
        {
            foreach (Employee e in list)
            {
                ListViewItem item = new ListViewItem(e.ID.ToString());
                item.SubItems.Add(e.Name);
                item.SubItems.Add(e.Age.ToString());
                item.SubItems.Add(e.Sex);
                this.lvShowEmployee.Items.Add(item);
            }
        }

        /// <summary>
        /// 打招呼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSayHi_Click(object sender, EventArgs e)
        {
            if (this.lvShowEmployee.SelectedItems.Count == 0)
            {
                return;
            }
            int index = this.lvShowEmployee.SelectedItems[0].Index;
            list[index].SayHi();
        }
    }
}
