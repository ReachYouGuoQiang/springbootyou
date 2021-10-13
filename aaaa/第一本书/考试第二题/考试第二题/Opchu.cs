using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 考试第二题
{
    public class Opchu:OpZong
    {
        public override void Suan()
        {
            base.Num3 = base.Num1 / base.Num2;
        }
    }
}
