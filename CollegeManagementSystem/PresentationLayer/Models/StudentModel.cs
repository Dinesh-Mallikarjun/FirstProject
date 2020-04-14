using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
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





//@{ 
//    ViewBag.Title = "ViewStudents";
//}
//<h2>College ID</h2>
//<form action = "/Admin/ViewStudentForCollege" method= "post" >
//    < label for="CollegeId">college id:</label>
//    <input type = "text" id= "id" name= "id" style= "background:inherit" />
//    < input type= "submit"value= "Go" style= "color:white;background:green" />

//</ form >
//< p align = "center" > @TempData["message"] </ p >
