using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ViewModel
    {
        public IEnumerable<MobileOperatorModel> mobileOperatorModels { get; set; }
        public IEnumerable<CustomerModel> customerModels { get; set; }
    }
}