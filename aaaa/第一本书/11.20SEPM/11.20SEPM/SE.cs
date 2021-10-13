using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._20SEPM
{
    public class SE:Employee
    {
        public int Pop { get; set; }
        public override void Show()
        {
            MessageBox.Show("我是SE");
        }
        //自己特有的属性
        //public int Pop { get; set; }

        //public override void Show()
        //{
        //    MessageBox.Show("我是SE");
        //}
    }
}
