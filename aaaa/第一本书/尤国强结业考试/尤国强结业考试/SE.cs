using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 尤国强结业考试
{
    public class SE:Employee
    {
        /// <summary>
        /// 受欢迎指数
        /// </summary>
        public string Popularity { get; set; }

        public SE() { }

        public override void SayHi()
        {
            MessageBox.Show(string.Format("大家好，我叫'{0}'，今年'{1}'，性别'{2}'，我的受欢迎指数{3}", Names, Age, Sex, this.Popularity));
        }
    }
}
