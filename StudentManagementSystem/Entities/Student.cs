using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int percentage { get; set; }


        [ForeignKey("College")]
        public int CollegeId { get; set; }

        public virtual College College { get; set; }
    }
}
