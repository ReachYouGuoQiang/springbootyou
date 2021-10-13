using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._20SEPM
{
    public class PM:Employee
    {
        public int  Years { get; set; }
        //自己特有的属性
        //public int Years { get; set; }
        public override void show()
        {
            MessageBox.Show("我是PM");
        }
        //public override void Show()
        //{
        //    MessageBox.Show("我是PM");
        //}
    }
}
