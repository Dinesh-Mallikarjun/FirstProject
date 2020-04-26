using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class GenderModel
    {
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public virtual ICollection<ApplyForJobModel> ApplyForjobs { get; set; }
    }
}