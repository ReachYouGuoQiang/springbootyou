using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._16上午车辆管理
{
    public class Vchicle
    {
        public string ID { get; set; }
        public string Names { get; set; }
        public string YongTu { get; set; }
        public double Price { get; set; }
        public string Address { get; set; }

        public Vchicle()
        { }
        public Vchicle(string name,string id,string yongtu,double price,string address)
        {
            this.ID = id;
            this.Names = name;
            this.YongTu = yongtu;
            this.Price = price;
            this.Address = address;
        }

        public void show()
        {
            Console.WriteLine("我是一辆:{0} 我的车牌号是:{1}  我的用途是:{2}   我的价格是:{3}   我的产地是:{4}",Names,ID,YongTu,Price,Address);
        }
    }
}
