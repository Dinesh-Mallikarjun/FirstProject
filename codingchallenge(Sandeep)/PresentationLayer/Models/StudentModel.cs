using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class StudentModel
    {
        public int Studentid { get; set; }
        public string StudentName { get; set; }
        public int ObtainedPercentage { get; set; }
        public int CollegeId { get; set; }
    }
}