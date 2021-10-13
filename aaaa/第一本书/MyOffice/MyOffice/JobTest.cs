using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
    /// <summary>
    /// 测试
    /// </summary>
    public class JobTest:Job
    {
        /// <summary>
        /// 测试用例的个数
        /// </summary>
        public int TestCases { get; set; }
        /// <summary>
        /// BUG数量
        /// </summary>
        public int Bugs { get; set; }
        /// <summary>
        /// 需要的工作日
        /// </summary>
        public int Days { get; set; }
        public override void Execute()
        {
            FrmTest frm = new FrmTest();
            frm.test = this;
            frm.Show();
            //FrmTest frm = new FrmTest();
            //frm.test = this;
            //frm.Show();
        }

        public override string Show()
        {
            return string.Format("行数{0}问题{1}天数{2}", TestCases, Bugs, Days);
            //return string.Format("行数{0}\n问题{1}\n天数{2}",TestCases,Bugs,Days);
        }
    }
}
