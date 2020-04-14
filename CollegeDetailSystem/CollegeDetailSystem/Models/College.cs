using System;
using System.Collections.Generic;

namespace CollegeDetailSystem.Models
{
    public partial class College
    {
        public College()
        {
            Student = new HashSet<Student>();
        }

        public int Collegeid { get; set; }
        public string ColegeName { get; set; }
        public string Location { get; set; }
        public decimal? CutOffPercentage { get; set; }
        public int? NumberofseatsAvailable { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}
