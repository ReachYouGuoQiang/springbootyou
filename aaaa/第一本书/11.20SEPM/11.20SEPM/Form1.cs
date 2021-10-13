using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._20SEPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PM p = new PM();
            p.Age = 22;
            p.Name = "jack";
            p.ID = "1001";
            p.Years = 5000;
            SE s = new SE();
            s.Name = "rosi";
            s.Age = 23;
            s.ID = "1002";
            s.Pop = 10000;
            List<Employee> list = new List<Employee>();
            list.Add(p);
            list.Add(s);
            foreach (Employee emp in list)
            {
                emp.Show();
            }
            //PM p = new PM();
            //p.Age = 22;
            //p.Name = "jack";
            //p.ID = "1001";
            //p.Years = 5000;
            //SE s = new SE();
            //s.Name = "rosi";
            //s.Age = 23;
            //s.ID = "1002";
            //s.Pop = 1000;
            ////创建一个泛型集合存储pm和se
            //List<Employee> list = new List<Employee>();
            //list.Add(p);
            //list.Add(s);
            ////循环遍历父类
            //foreach (Employee emp in list)
            //{
            //    emp.Show();
            //}
        }
    }
}
