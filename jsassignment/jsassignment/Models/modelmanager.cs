using business;
using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jsassignment.Models
{
    public class modelmanager
    {
        public void AddDemo(demomodel d)
        {
            demoentity demoentity = new demoentity();
            demoentity.firstname = d.firstname;
            demoentity.lastname = d.lastname;
            demoentity.email = d.email;
            demoentity.phone = d.phone;
            demoentity.password = d.password;
            demoentity.confirmpassword = d.confirmpassword;
            demoentity.description = d.description;


            businessclass business = new businessclass();
            business.AddDemo(demoentity);
        }

        }
    }