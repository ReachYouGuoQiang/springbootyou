using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算机
{
    public class Opcheng:Opercation
    {
        public override void Suan()
        {
            base.Result = base.Num1 * base.Num2;
        }
    }
}
