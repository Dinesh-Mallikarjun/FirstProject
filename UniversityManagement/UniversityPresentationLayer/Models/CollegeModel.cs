using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityPresentationLayer.Models
{
    public class CollegeModel 
    {
        public int collegeId { get; set; }
        public string collegeName { get; set; }
        public int totalStudents { get; set; }
        public int UniversityId { get; set; }
                     
     
    }
}