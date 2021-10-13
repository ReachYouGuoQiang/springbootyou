using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11章汽车租赁系统
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public double DailyRent { get; set; }
        public string LisenceNO { get; set; }
        public string Name { get; set; }
        public int RentDate { get; set; }
        public string RentUser { get; set; }
        public int YearsOfService { get; set; }

        public abstract double CalcTotal();
    }
}
