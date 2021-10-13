using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._9作业
{
    public class It
    {
        public void Carted(Computer[] cs)
        {
            Random rd = new Random();
            foreach (Computer c in cs)
            {
                c.id = c.xinghao + "-" + rd.Next(1000, 10000);
            }
        }
    }
}
