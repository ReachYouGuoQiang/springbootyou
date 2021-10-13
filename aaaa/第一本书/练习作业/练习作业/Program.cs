using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习作业
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Name = "奔驰";
            c.Color = "黑色";
            c.Address = "中国";
            c.show();
            Car c1 = new Car();
            c1.Name = "宝马";
            c1.Color = "红色";
            c1.Address = "德国";
            c1.show(555);
        }
    }
}
