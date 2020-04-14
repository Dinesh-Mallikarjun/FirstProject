using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public class Student
    {
        private string name;
        private int rollno;
    public string Name { get => name; set => name = value; }
        public int Rollno { get => rollno; set => rollno = value; }
    }
}