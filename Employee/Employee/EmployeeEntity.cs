using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee
{
    public class EmployeeEntity
    {
        string name;
        int id;
        int age;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
    }
}