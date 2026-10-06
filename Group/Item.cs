using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    internal class Item
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Item(string description, int quantity, decimal price)
        {
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }
}
