using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityPresentationLayer.Models
{
    public class UniversityModel:IComparable<UniversityModel>
    {   
            
        public int universityId { get; set; }

        [Required]
        public string universityName { get; set; }

        [Required]
        public int totalColleges { get; set; }

        public List<CollegeModel> colleges { get; set; }

        public int CompareTo(UniversityModel other)
        {
            return this.totalColleges.CompareTo(other.totalColleges);
        }
    }
}