using System;
using System.Collections.Generic;

namespace UserDetailSystem.Models
{
    public partial class Subjects
    {
        public Subjects()
        {
            Teachers = new HashSet<Teachers>();
        }

        public int Id { get; set; }
        public string Subname { get; set; }
        public int? Modules { get; set; }

        public ICollection<Teachers> Teachers { get; set; }
    }
}
