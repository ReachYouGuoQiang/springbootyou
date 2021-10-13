using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheckSystem
{
    public class HealthCheckSet
    {
        public int Price { get; set; }
        public string SetName { get; set; }

        public List<HealthCheckItem> items = new List<HealthCheckItem>();

        public HealthCheckSet() { }

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
                totalPrice += item.Price;
            }
            this.Price = totalPrice;
        }
    }
}
