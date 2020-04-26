using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ViewModel
    {
        public IEnumerable<ApplyForJobModel> applyForJobModels { get; set; }
        public IEnumerable<GenderModel> genderModels { get; set; }
        public IEnumerable<ContactModel> contactModels { get; set; }
        
    }
}