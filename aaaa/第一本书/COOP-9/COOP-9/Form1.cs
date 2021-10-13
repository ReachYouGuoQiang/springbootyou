using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace COOP_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //文件路径
            string pat = this.txtAddress.Text;
            string content = this.tetShow.Text;
            //创建文件流
            FileStream fs = new FileStream(pat,FileMode.Create);
            //键器
            StreamWriter sw = new StreamWriter(fs);
            //操作写入
            sw.Write(content);
            //关闭键器
            sw.Close();
            //关闭文件流
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //打开文件夹
            this.openFileDialog1.ShowDialog();
            //获得地址
            string pat = this.openFileDialog1.FileName;
            //判断是否为空
            if (string.IsNullOrEmpty(pat))
            {
                return;
            }
            //创建文件流
            FileStream fs = new FileStream(pat,FileMode.OpenOrCreate);
            //创建读取器
            StreamReader sr = new StreamReader(fs);
            //声明一个变量来进行操作获得他读取到的值
            string content = sr.ReadToEnd();
            //将获得的值存放到对应的文本框里
            this.tetShow.Text = content;
            //关闭读取器
            sr.Close();
            //关闭文件流
            fs.Close();
        }

      
    }
}
