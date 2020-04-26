using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ApplyForJobModel
    {
        public int Companyid { get; set; }
        public string CompanyName { get; set; }
        public string CandidatName { get; set; }
        public Nullable<decimal> mobileNumber { get; set; }
        public string Email { get; set; }
        public Nullable<int> ContactId { get; set; }
        public Nullable<int> Genderid { get; set; }
        public string CurrentRole { get; set; }
        public string collegename { get; set; }
        public string PreOrgName { get; set; }

        public virtual ContactModel Contact { get; set; }
        public virtual GenderModel Gender { get; set; }
    }
}
