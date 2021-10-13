using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 员工回家
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            Car c = new Car();
            Bus b = new Bus();
            Zixingche z=new Zixingche();
            e.Run(c);
        }
    }
}
