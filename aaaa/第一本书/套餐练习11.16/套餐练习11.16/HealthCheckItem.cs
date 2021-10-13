using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 套餐练习11._16
{
     public class HealthCheckItem
    {
         /// <summary>
         /// 项目名称
         /// </summary>
        public string Description { get; set; }
         /// <summary>
         /// 名称
         /// </summary>
        public string ItemName { get; set; }
         /// <summary>
         /// 价格
         /// </summary>
        public double Price { get; set; }

         //创建构造函数
        public HealthCheckItem() { }
        public HealthCheckItem(string itemName, int price, string description)
        {
            this.Description = description;
            this.ItemName = itemName;
            this.Price = price;
        }

    }
}
