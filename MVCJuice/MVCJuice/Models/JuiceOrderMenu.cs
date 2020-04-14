using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJuice.Models
{
    public class JuiceOrderMenu
    {   
            public int OrderId { get; set; }
            public int JuiceId { get; set; }
            public int Quantity { get; set; }
            public int TotalPrice { get; set; }      

    }
}