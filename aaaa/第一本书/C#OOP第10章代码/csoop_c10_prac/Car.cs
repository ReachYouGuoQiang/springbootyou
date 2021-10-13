using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csoop_c10_prac
{
    public class Car : Vehicle
    {
        public override double CalcTotal()
        {
            return RentDate * DailyRent;
        }
    }
}
