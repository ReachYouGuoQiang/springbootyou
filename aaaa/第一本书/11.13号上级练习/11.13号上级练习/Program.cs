using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._13号上级练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //SE s1 = new SE();
            //s1.show();
            //SE s2 = new SE(1, "1002", "张三");
            //s2.show();

            //PM pm = new PM();
            //pm.Name = "张三";
            //pm.Jiangjin = 1000;
            //pm.Jiangjin = 10000;
            //pm.Fenhong = 1000000;
            //SE se = new SE();
            //se.Jiben = 10000;
            //se.KaoHe = 10000;
            //se.Name = "李四";
            //Boss boss = new Boss();
            //boss.Calc(pm);
            //boss.Calc(se);

            Car car = new Car();
            car.Name = "五菱宏光";
            car.Color = "白色";
            car.Address = "中国";
            car.run();
            Car car2 = new Car();
            car2.Name = "奥拓";
            car2.Color = "红色";
            car2.Address = "中国";
            car2.run(980);
        }
    }
}
