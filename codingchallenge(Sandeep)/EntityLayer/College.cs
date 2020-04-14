using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class College
    {
        public int CollegeId { get; set; }

        public string CollegeName { get; set; }

        public string Location { get; set; }

        public int CutOff { get; set; }

        public int NoOfAvailableSeats { get; set; }
        
    }
}
