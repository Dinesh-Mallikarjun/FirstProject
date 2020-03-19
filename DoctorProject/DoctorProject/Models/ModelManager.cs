using DoctorBusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorProject.Models
{
    public class ModelManager
    {
        public void AddDoctor(DoctorModel doctorModel)
        {
            Doctor doctor = new Doctor();

            doctor.DoctorName = doctorModel.DoctorName;
            doctor.Salary = doctorModel.Salary;

            Business business = new Business();
            business.AddDoctor(doctor);

        }
        public void AddPatient(PatientModel patientModel)
        {
            Patient patient = new Patient();
            patient.DoctorId = patientModel.DoctorId;

            patient.PatientName = patientModel.PatientName;

            patient.PatientBill = patientModel.PatientBill;

            Business business = new Business();

            business.AddPatient(patient);
           

        }
        public List<PatientModel> GetPatientDetials(int id)
        {
            Business business = new Business();
            List<PatientModel> patient_Models = new List<PatientModel>();

            List<Patient> patients = business.GetPatientDetials(id);

            foreach (var patient in patients)
            {
                PatientModel patient_Model = new PatientModel();

                patient_Model.PatientId = patient.PatientId;
                patient_Model.PatientName = patient.PatientName;
                patient_Model.PatientBill = patient.PatientBill;

                patient_Models.Add(patient_Model);
            }
            return patient_Models;
        }
        public List<DoctorModel> GetDoctorName(string name)
        {
            Business business = new Business();
            List<Doctor> doctors = business.GetDoctorName(name);
            List<DoctorModel> doctorModels = new List<DoctorModel>();
            foreach (var i in doctors)
            {
                DoctorModel doctorModel = new DoctorModel();
                doctorModel.DoctorName = i.DoctorName;

                doctorModels.Add(doctorModel);
            }
            return doctorModels;
          }
    }
}