using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._13号上级练习
{
    public class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Address { get; set; }

        public Car() { }
        public Car(string name,string color,string address)
        {
            this.Name = name;
            this.Color = color;
            this.Address = address;
        }

        public void run()
        {
            Console.WriteLine("我是一辆{0}车，颜色是{1}，产地是{2}",Name,Color,Address);
        }

        public void run(int speed)
        {
            Console.WriteLine("我是一辆{0}车，颜色是{1}，产地是{2}，最高时速{3}", Name, Color, Address,speed);
        }
    }
}
