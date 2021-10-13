using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._18号体检套餐
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
        public int Price { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public HealthCheckItem() { }

        public HealthCheckItem(string itemName,int price, string description)
        {
            this.Description = description;
            this.ItemName = itemName;
            this.Price = price;
        }
    }
}
