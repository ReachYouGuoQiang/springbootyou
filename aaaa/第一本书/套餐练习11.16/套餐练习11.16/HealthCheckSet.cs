using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 套餐练习11._16
{
    public class HealthCheckSet
    {
        /// <summary>
        /// 作为存储HealthCheckItem的数据结构
        /// </summary>
        public List<HealthCheckItem> items { get; set; }
        /// <summary>
        /// 套餐所有项目的价格总和
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 套餐名称
        /// </summary>
        public string SetName { get; set; }

        //创建构造函数
        public HealthCheckSet() { }

        #region 计算所有的项目总价存在套餐里
        public HealthCheckSet(List<HealthCheckItem> items, string setName)
        {
            this.items = items;
            this.SetName = setName;
        }

        public void CalcPrice()
        {
            int totalPrice = 0;
            foreach (HealthCheckItem item in this.items)
            {
                totalPrice += items.Price;
            }
            this.Price = totalPrice;
        }
        #endregion
    }
}
