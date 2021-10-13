using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 动物看病
{
    public class Dog : Pet
    {
        public override void zhiliao()
        {
            Console.WriteLine("狗再叫");
        }
    }
}
