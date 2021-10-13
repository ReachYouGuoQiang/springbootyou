using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型与引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer[]cs = new Computer[3];
            cs[0] = new Computer();
            cs[0].XingHao = "daw-das";
            cs[0].Time = "2020-9-9";
            cs[1] = new Computer();
            cs[1].XingHao = "daw-zxc";
            cs[1].Time = "2020-9-9";
            cs[2] = new Computer();
            cs[2].XingHao = "daw-xvc";
            cs[2].Time = "2020-9-9";

            IT it = new IT();
            it.CrateId(cs);

            foreach (Computer c in cs)
            {
                c.Show();
            }
        }
    }
}
