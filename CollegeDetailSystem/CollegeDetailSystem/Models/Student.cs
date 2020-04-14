using System;
using System.Collections.Generic;

namespace CollegeDetailSystem.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? PercentageObtained { get; set; }
        public int? Collegeid { get; set; }

        public College College { get; set; }
    }
}
