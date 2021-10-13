using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四章上机练习二
{
   public class Boos
    {
       public void Gra(SE se) 
       {
           int sum = se.JiBen + se.Kaohe;
           Console.WriteLine("我的名字{0},总工资{1}",se.Name,sum);
       }

       public void Graid(PM pm)
       {
           int sum = pm.Jiben + pm.FenHong + pm.Xiangmu;
           Console.WriteLine("我的名字{0},总工资{1}", pm.Name, sum);
       }
    }
}
