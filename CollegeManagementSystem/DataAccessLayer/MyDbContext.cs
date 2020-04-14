using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace DataAccessLayer
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("MysqlConnectionString") { }


        public virtual DbSet<College> colleges { get; set; }
        public virtual DbSet<Student> students { get; set; }

       
    }
}