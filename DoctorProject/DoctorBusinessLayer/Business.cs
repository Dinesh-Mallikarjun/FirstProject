using DataAcessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorBusinessLayer
{
    public class Business
    {
        static DataAcess DataAcess = new DataAcess();
        public void AddDoctor(Doctor doctor)
        {
            DataAcess.AddDoctor(doctor);
        }

        public void AddPatient(Patient patient)
        {
            DataAcess.AddPatient(patient);
        }
        public List<Patient> GetPatientDetials(int id)
        {
            return DataAcess.GetPatientDetials(id);
        }
        public List<Doctor> GetDoctorName(string name)
        {
            List<Doctor> doctors = new List<Doctor>();
            doctors = DataAcess.GetDoctorName(name);
            return doctors;
        }

        public List<Doctor> DisplayDoctors()
        {
           return DataAcess.DisplayDoctors();
        }
    }
}
