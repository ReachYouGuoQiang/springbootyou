using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._13号上级练习
{
    public class SE
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int Jiben { get; set; }
        public int KaoHe { get; set; }

        public SE()
        {
            this.ID = "1001";
            this.Name = "tom";
            this.Age = 22;
        }
        public SE(int i,string id,string name)
        {
            this.Age = i;
            this.Name = name;
            this.ID = id;
        }
        public void show()
        {
            Console.WriteLine("大家好，我叫{0}，我的工号是{1}，我的年龄{2}",Name,ID,Age);
        }
    }
}
