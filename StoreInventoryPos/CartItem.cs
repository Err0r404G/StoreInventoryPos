using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventoryPos
{
    public class CartItem
    {
        public string ProductID { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double Total => Price * Quantity;
    }
}
