using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        public Order Order { get; set; }

        public List<Product> Products { get; set; }
        public decimal RetailPrice { get; set; }
    }
}
