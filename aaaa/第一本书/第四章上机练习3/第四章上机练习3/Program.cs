using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四章上机练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            SE s = new SE();
            s.Name = "保时捷";
            s.Color = "黑色";
            s.Address = "叙利亚";
            s.Run();

            SE s1 = new SE();
            s1.Name = "保时捷";
            s1.Color = "黑色";
            s1.Address = "叙利亚";
            s1.Run(5621);
        }
    }
}
