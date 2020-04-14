﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeManagementPresentationLayer.Models
{
    public class LoginModel
    {   
        [Required]
        public string UserID{get; set;}

        [Required]
        public string Password{ get; set; }
    }
}