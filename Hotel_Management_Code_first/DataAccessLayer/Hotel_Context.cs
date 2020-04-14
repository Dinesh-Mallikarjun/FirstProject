using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Hotel_Context:DbContext
    {
        public Hotel_Context() : base("connection123")
        {
        }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}
