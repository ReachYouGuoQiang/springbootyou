using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._9作业
{
    public class Computer
    {
        //2020年11月10日08:59:16尤国强第五遍
        public string id { get; set; }
        public string time { get; set; }
        public string xinghao { get; set; }

        public void show()
        {
            Console.WriteLine("{0}\t\t{1}\t\t{2}",this.xinghao,this.id,this.time);
        }
    }
}
