using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models
{
    public class CollegeModel : IComparable<CollegeModel>
    {
        public int collegeId { get; set; }

        [Required]
        public string collegeName { get; set; }
        [Required]

        public string location { get; set; }
        [Required]
        public int CutOffPercentage { get; set; }
        [Required]
        [Range(1, 100)]
        public int AvailableSeat { get; set; }
        public List<StudentModel> students { get; set; }

        public int CompareTo(CollegeModel other)
        {
            return this.AvailableSeat.CompareTo(other.AvailableSeat);
        }
    }
}