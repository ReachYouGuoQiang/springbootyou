using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 月考
{
    public class Dog:Pet
    {
        public override void zhiliao()
        {
            Console.WriteLine("为狗狗看病---\n打针，吃药");
        }
    }
}
