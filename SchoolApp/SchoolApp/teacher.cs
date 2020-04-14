namespace SchoolApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int teachersid { get; set; }

        [StringLength(20)]
        public string tname { get; set; }

        public int? salary { get; set; }

        public int? subId { get; set; }

        public virtual subject subject { get; set; }
    }
}
