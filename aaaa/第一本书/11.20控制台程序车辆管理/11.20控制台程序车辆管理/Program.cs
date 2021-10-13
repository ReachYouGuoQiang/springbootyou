using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._20控制台程序车辆管理
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle v = new Vehicle();
            v.show();
            Car c = new Car("三蹦子", "红色", "300");
            c.show();
        }
    }
}
