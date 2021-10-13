using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型与引用类型
{
    public class IT
    {
        public void CrateId(Computer[] cs)
        {
            Random rd = new Random();
            foreach (Computer c in cs)
            {
                c.ID = c.XingHao + "-" + rd.Next(1000, 10000);
            }
        }
    }
}
