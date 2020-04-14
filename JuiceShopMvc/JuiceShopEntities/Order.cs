using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceShopEntities
{
    class Order
    {
        public int OrderId { get; set; }
        public int JuiceId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
