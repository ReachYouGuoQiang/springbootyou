using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._20SEPM
{
    /// <summary>
    /// 父类
    /// </summary>
    public class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        //代表公有的属性
        //public string Name { get; set; }
        //public string Gender { get; set; }
        //public string ID { get; set; }
        //public int Age { get; set; }
        public virtual void Show()
        {
            MessageBox.Show("我是父类");
        }
        //public virtual void Show()
        //{
        //    MessageBox.Show("我是父类");
        //}
    }
}
