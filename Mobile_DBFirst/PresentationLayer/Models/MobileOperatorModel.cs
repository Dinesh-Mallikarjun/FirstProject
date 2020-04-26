using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class MobileOperatorModel
    {
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public decimal OperatorRating { get; set; }
    }
}