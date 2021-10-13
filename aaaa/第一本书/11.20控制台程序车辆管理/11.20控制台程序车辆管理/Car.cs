using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._20控制台程序车辆管理
{
    public class Car:Vehicle
    {
        public Car() { }
        public Car(string name, string color,string address):base(name,color,address)
        {
            
        }
        public void Run() 
        {
            Console.WriteLine("我是一辆{0}车  我的产地是{1} 我的颜色是{2}",Names,Address,Color);
        }
        public void Run(int spend)
        {
            Console.WriteLine("我是一辆{0}车  我的产地是{1} 我的颜色是{2}  最高时速{3}", Names, Address,Color,spend);
        }
        
    }
}
