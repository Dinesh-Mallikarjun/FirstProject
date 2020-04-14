using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enitities
{
    public class College 
    {
        public int CollegeId { get; set; }
        public string CollegeName { get; set; }
        public string Location { get; set; }
        public Nullable<decimal> CutOffPercentage { get; set; }
        public Nullable<int> NumberOfSeatsAvailable { get; set; }

        public virtual ICollection<Student>Students{ get; set; }
    }
}
