using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习作业
{
    public class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Address { get; set; }

        public void Run() { }
        public void Run(string name,string color,string address)
        {
            this.Name = name;
            this.Color = color;
            this.Address = address;
        }
        public void show()
        {
            Console.WriteLine("我是{0}车   我的颜色是{1}    我的产地在{2}", Name, Color, Address);
        }
        public void show(int spead)
        {
            Console.WriteLine("我是{0}车   我的颜色是{1}    我的产地在{2} 最高时速{3}",Name,Color,Address,spead);
        }
    }
}
