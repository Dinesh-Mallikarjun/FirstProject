using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{   
        public class College
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public int collegeId { get; set; }
            public string collegeName { get; set; }
            public string location { get; set; }
            public int CutOffPercentage { get; set; }
            public int AvailableSeat { get; set; }
            public List<Student> students { get; set; }
        }
    
}
