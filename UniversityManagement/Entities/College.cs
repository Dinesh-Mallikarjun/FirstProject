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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int collegeId { get; set; }
        public string collegeName { get; set; }
        public int totalStudents { get; set; }
        
        [ForeignKey("University")]
        public int UniversityId { get; set; }

        public virtual University University { get; set; }

    }
}
