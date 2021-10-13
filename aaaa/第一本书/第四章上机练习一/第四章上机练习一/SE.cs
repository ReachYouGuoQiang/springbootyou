using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四章上机练习一
{
   public class SE
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public SE() 
        {
            Name = "扇贝";
            ID = "1001";
            Age = 18;
        }
        public SE(string name,string id,int i)
        {
            Name = name;
            ID = id;
            Age = i;
        }
        public void Show() 
        {
            Console.WriteLine("我的名字是{0},工号{1},年龄{2}",Name,ID,Age);
        }
    }
}
