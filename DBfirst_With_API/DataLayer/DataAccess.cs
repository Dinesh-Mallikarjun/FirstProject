using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataAccess
    {
        DoctorEntities doctorEntities = new DoctorEntities();
        public int  AddDoctors(Doctor doctor )
        {
            var entity = doctorEntities.Doctors.Add(doctor);
            doctorEntities.SaveChanges();
            if(entity == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public List<Doctor> DisplayDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            doctors = doctorEntities.Doctors.ToList();
            return doctors;
        }
        public int AddPatients(Patient patient)
        {
            var entity = doctorEntities.Patients.Add(patient);
            doctorEntities.SaveChanges();
            if (entity == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public List<Patient> DisplayPatients(int id)
        {
            List<Doctor> doctors = new List<Doctor>();
            var entity = doctorEntities.Doctors.Where(m => m.DoctoreId == id);
            Doctor doctorData = entity.FirstOrDefault();
            List<Patient> patients = new List<Patient>();
            foreach(Patient patient in doctorEntities.Patients)
            {
                if(patient.DoctorId==doctorData.DoctoreId)
                {
                    patient.DoctorId = doctorData.DoctoreId;
                }
            }
            return patients;
        }
    }
}
