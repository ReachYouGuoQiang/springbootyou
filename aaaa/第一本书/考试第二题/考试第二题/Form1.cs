using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 考试第二题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.tetNum1.Text);
            string suan = this.cbosuan.Text;
            int num3 = int.Parse(this.tetNum2.Text);
            OpZong o = null;
            switch(suan)
            {
                case  "+":
                    o=new Opjia();
                    break;
                case "-":
                    o = new Opjian();
                    break;
                case "*":
                    o = new Opcheng();
                    break;
                case "/":
                    o = new Opchu();
                    break;
            }
            o.Num1 = num1;
            o.Num2 = num3;
            o.Suan();
            this.lblSuan.Text = o.Num3.ToString();
        }
    }
}
