using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ContactModel
    {
        public int ContactId { get; set; }
        public string ContactedBy { get; set; }

        public virtual ICollection<ApplyForJobModel> ApplyForjobs { get; set; }
    }
}