using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Business
    {
        DataAccess dataAccess = new DataAccess();
        public int AddDoctor(Doctor doctor)
        {
           return  dataAccess.AddDoctors(doctor);
        }
        public List<Doctor> DisplayDoctors()
        {
            List<Doctor> doctors = dataAccess.DisplayDoctors();
            return doctors;
        }
        public int AddPatients(Patient patient)
        {
            return dataAccess.AddPatients(patient);
        }
        public List<Patient> DisplayPatients(int id)
        {
            List<Patient> patients = dataAccess.DisplayPatients(id);
            return patients;
        }
    }
}
