using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 动物看病
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor d = new Doctor();
            d.zhiliao(new Dog());
            d.zhiliao(new Pig());
        }
    }
}
