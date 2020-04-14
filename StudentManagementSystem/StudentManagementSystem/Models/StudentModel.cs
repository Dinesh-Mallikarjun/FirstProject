using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models
{
    public class StudentModel
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int percentage { get; set; }


        [Required]
        public int CollegeId { get; set; }
    }
}