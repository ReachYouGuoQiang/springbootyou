using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._12._07_test
{
    public abstract class Employee
    {
        public int Age { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

        public Employee() { }

        public abstract void SayHi();
    }
}
