using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookApplicationPresentationLayer.Models
{
    public class BookMenuModel
    {   
       //[Required(ErrorMessage="Enter book title")]
        public string BookTitle { get; set; }
      // [Required(ErrorMessage = "Enter book author")]
        public string Author { get; set; }

        //[Required(ErrorMessage = "Enter book Location")]
        public string Location { get; set; }

        //[Required(ErrorMessage = "Enter book Category")]
        public string Category { get; set; }

        //[Required(ErrorMessage = "Enter book Price")]
        public int Price { get; set; }

//        [Required(ErrorMessage = "Enter book Tags")]
        public string Tags { get; set; }
    }
}