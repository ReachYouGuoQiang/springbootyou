using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11章汽车租赁系统
{
    public  class Truck:Vehicle
    {
        /// <summary>
        /// 承重
        /// </summary>

        public int load;
        public int Load { get { return load; } set { load=value;} }

        public override double CalcTotal()
        {
            return RentDate * DailyRent;
        }

    }
}
