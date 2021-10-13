using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._13号上级练习
{
    public class Boss
    {
        public void Calc(PM pm)
        {
            int sum = pm.Jiangjin + pm.Jiangjin + pm.Fenhong;
            Console.WriteLine("姓名{0}，总工资{1}",pm.Name,sum);
        }

        public void Calc(SE se)
        {
            int sum = se.Jiben + se.KaoHe;
            Console.WriteLine("姓名{0}，总工资{1}", se.Name, sum);
        }
    }
}
