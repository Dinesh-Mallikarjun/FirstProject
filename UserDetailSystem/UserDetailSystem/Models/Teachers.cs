using System;
using System.Collections.Generic;

namespace UserDetailSystem.Models
{
    public partial class Teachers
    {
        public int Teachersid { get; set; }
        public string Tname { get; set; }
        public int? Salary { get; set; }
        public int? SubId { get; set; }
        public Subjects Sub { get; set; }
    }
}
