using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._18号体检套餐
{
    public class HealthCheckSet
    {
        /// <summary>
        /// 套餐名称
        /// </summary>
        public string SetName { get; set; }
        /// <summary>
        /// 作为存储HealthCheckItem的数据结构
        /// </summary>
        public List<HealthCheckItem> items { get; set; }
        /// <summary>
        /// 套餐总价格
        /// </summary>
        public int  Price { get; set; }
        /// <summary>
        /// 创建构造函数
        /// </summary>
        public HealthCheckSet() { }

        public HealthCheckSet(List<HealthCheckItem> items, string setName)
        {
            this.items = items;
            this.SetName = setName;
        }
        #region 算出套餐总价格
        /// <summary>
        /// 套餐价格的总和
        /// </summary>
        public void CalPrice()
        {
            int totalPrice = 0;
            foreach (HealthCheckItem item in this.items)
            {
                totalPrice += item.Price;
            }
            this.Price = totalPrice;
        }
        #endregion

    }
}
