using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11章汽车租赁系统
{
    public class Car:Vehicle
    {
        public override double CalcTotal()
        {
            return RentDate * DailyRent;
        }
    }
}
