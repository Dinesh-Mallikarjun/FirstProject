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
        public void AddDoctor(Doctor doctor)
        {
            DataAcess data = new DataAcess();
            data.AddDoctor(doctor);

        }

        public void AddPatient(Patient patient)
        {
            DataAcess data = new DataAcess();
            data.AddPatient(patient);

        }
        public List<Patient> GetPatientDetials(int id)
        {
            DataAcess dataaccesslayer = new DataAcess();
            return dataaccesslayer.GetPatientDetials(id);

        }


        public List<Doctor> GetDoctorName(string name)
        {
            DataAcess dataAcess = new DataAcess();
            List<Doctor> doctors = new List<Doctor>();

            doctors = dataAcess.GetDoctorName(name);
            return doctors;
        }
    }
}
