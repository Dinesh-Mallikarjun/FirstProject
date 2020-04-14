using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JuiceMVC.Repository;

namespace JuiceMVC.Models
{
    public class JuiceModel
    {

   
        public int JuiceId { get; set; }

       
        public string Flavour { get; set; }

   
        public int Price { get; set; }

        internal void UpdateJuice(JuiceRepository obj)
        {
            throw new NotImplementedException();
        }
    }
}