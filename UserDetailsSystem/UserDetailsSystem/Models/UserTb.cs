using System;
using System.Collections.Generic;

namespace UserDetailsSystem.Models
{
    public partial class UserTb
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Adres { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        
        public string TelePhonno { get; set; }
       
    }
}
