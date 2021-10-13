using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算机
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
            int num2 = int.Parse(this.tetnum2.Text);
            string sum = this.cboop.Text;
            Opercation o = null;
            switch (sum)
            { 
                case "+":
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
            o.Num2 = num2;
            o.Suan();
            this.lblshow.Text = o.Result.ToString();
            //int num1 = int.Parse(this.tetNum1.Text);
            //int num2 = int.Parse(this.tetnum2.Text);
            //string sum = this.cboop.Text;
            //Opercation o = null;
            //switch (sum)
            //{
            //    case "+":
            //        o = new Opjia();
            //        break;
            //    case "-":
            //        o = new Opjian();
            //        break;
            //    case "*":
            //        o = new Opcheng();
            //        break;
            //    case "/":
            //        o = new Opchu();
            //        break;
            //}
            //o.Num1 = num1;
            //o.Num2 = num2;
            //o.Suan();
            //this.lblshow.Text = o.Result.ToString();
        }
    }
}
