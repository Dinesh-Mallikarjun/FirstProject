using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitities
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> PercentageObtained { get; set; }
        public Nullable<int> CollegeId { get; set; }
        public virtual College College { get; set; }
    }
}
