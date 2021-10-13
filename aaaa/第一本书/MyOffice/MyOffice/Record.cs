using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
    public class Record
    {
        public string id { get; set; }
        public string Name { get; set; }
        public DateTime SignIn { get; set; }
        public DateTime SignOut { get; set; }
    }
}
