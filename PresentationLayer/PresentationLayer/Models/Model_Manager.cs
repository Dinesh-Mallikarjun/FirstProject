using Doctor_Entity;
using DP_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class Model_Manager
    {
        public void AddDoctor(Doctor_Model doctor_Model)
        {

            Doctor doctor = new Doctor();
            
            doctor._DoctorName = doctor_Model._DoctorName;
            doctor._Salary = doctor_Model._Salary;

            Businesslayer businesslayer = new Businesslayer();
            businesslayer.AddDoctor(doctor);


        }
    }
}