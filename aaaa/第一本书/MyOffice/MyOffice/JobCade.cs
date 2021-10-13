using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
    /// <summary>
    /// 编码
    /// </summary>
    public class JobCade : Job
    {
        /// <summary>
        /// 测试的行数
        /// </summary>
        //public int CodeLines { get; set; }
        //public int Questions { get; set; }
        //public int Days { get; set; }
        public int CodeLines { get; set; }
        public int Questions { get; set; }
        public int Days { get; set; }

        public override void Execute()
        {
            FrmCade frm=new FrmCade();
            frm.cade=this;
            frm.Show();
            //FrmCade frm = new FrmCade();
            //frm.cade = this;
            //frm.Show();
        }

        public override string Show()
        {
            return string.Format("行数{0}问题{1}天数{2}", CodeLines, Questions, Days);
            //return string.Format("行数{0}\n问题{1}\n天数{2}",CodeLines,Questions,Days);
        }
    }
}
