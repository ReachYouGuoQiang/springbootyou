using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
    public abstract class Job
    {
        public string Type { get; set; }
        public string Names { get; set; }
        public string Description { get; set; }
        //public string Type { get; set; }
        //public string Names { get; set; }
        //public string Description { get; set; }
        public abstract void Execute();
        public abstract string Show();
        //public abstract void Execute();
        //public abstract string Show();
    }
}
