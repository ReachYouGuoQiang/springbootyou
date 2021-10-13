using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四章上机练习二
{
    class Program
    {
        static void Main(string[] args)
        {
            SE s = new SE();
            s.Name = "张三";
            s.JiBen = 121;
            s.Kaohe = 12231;

            PM pm = new PM();
            pm.Name = "李四";
            pm.Jiben = 500;
            pm.Xiangmu = 600;
            pm.FenHong = 112;

            Boos bo = new Boos();
            bo.Gra(s);
            bo.Graid(pm);
        }
    }
}
