using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public int NumberOfPeople { get; set; }
        public Nullable<int> BillAmount { get; set; }
        public Nullable<int> Reservation_Id { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
