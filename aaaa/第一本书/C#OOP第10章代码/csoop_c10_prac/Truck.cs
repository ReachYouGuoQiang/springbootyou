using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csoop_c10_prac
{
    public class Truck : Vehicle
    {
        public int load;
        public int Load { get { return load; } set { load = value; } }

        public override double CalcTotal()
        {
            return RentDate * DailyRent;
        }
    }
}
