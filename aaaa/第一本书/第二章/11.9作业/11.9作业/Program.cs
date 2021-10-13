using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._9作业
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer[]cm = new Computer[1];
            cm[0] = new Computer();
            cm[0].xinghao = "qwe-qwe";
            cm[0].time = "2020-9-9";

            It i = new It();
            i.Carted(cm);
            foreach (Computer c in cm)
            {
                c.show();
            }
        }
    }
}
