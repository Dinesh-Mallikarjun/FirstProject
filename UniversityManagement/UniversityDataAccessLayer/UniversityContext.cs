using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDataAccessLayer
{
     class UniversityContext:DbContext
    {
        public UniversityContext() : base("connectionString")
        {

        }
        public virtual DbSet<University> universities { get; set; }

        public virtual DbSet<College> colleges { get; set; }
    }
}
