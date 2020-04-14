using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeedata
{
    class EEntity
    {
        private string name;
        private int id;
        private int age;
        private int salary;
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
