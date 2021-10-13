using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheckSystem
{
    public class HealthCheckItem
    {
        public string Description { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }

        public HealthCheckItem() { }

        public HealthCheckItem(string itemName,int price, string description)
        {
            this.Description = description;
            this.ItemName = itemName;
            this.Price = price;
        }

    }
}
