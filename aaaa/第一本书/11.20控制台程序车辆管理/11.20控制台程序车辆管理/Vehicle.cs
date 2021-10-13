using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._20控制台程序车辆管理
{
    public class Vehicle
    {
        public string Color { get; set; }
        public string Names { get; set; }
        public string Address { get; set; }


        public Vehicle()
        { }
        public Vehicle(string name, string color, string address)
        {
            this.Color = color;
            this.Names = name;
            this.Address = address;
        }
        public void show()
        {
            Console.WriteLine("我是一辆:{0} 我的颜色是:{1}   我的产地是:{2}", Names, Color, Address);
        }
    }
}
