using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四章上机练习3
{
   public class SE
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Address { get; set; }
        public SE() { }
        public SE(string name,string color,string address)
        {
            Name = name;
            Color = color;
            Address = address;
        }
        public void Run() 
        {
            Console.WriteLine("车名{0},颜色{1},产地{2}",Name,Color,Address);
        }

        public void Run(int shisu)
        {
            Console.WriteLine("车名{0},颜色{1},产地{2},时速{3}", Name, Color, Address,shisu);
        }
    }
}
