using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型与引用类型
{
    public class Computer
    {
        public string  XingHao { get; set; }
        public string ID { get; set; }
        public string  Time { get; set; }

        public void Show()
        {
            Console.WriteLine("{0}\t\t\t{1}\t\t\t{2}",this.XingHao,this.ID,this.Time);
        }
    }
}
