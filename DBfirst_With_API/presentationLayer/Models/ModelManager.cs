using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace presentationLayer.Models
{
    public class ModelManager
    {
        public int AddDoctor(DoctorModel doctorModel)
        {
            Doctor doctor = new Doctor();
            doctor.DoctorName = doctorModel.DoctorName;
            doctor.Salary = doctorModel.Salary;

            Business business = new Business();
            return business.AddDoctor(doctor);
        }
        public List<DoctorModel> DisplayDoctors()
        {
            Business business = new Business();
            List<Doctor> doctors = business.DisplayDoctors();
            List<DoctorModel> doctorModels = new List<DoctorModel>();
            foreach (var doctor in doctors)
            {
                DoctorModel doctorModel = new DoctorModel();
                doctorModel.DoctoreId = doctor.DoctoreId;
                doctorModel.DoctorName = doctor.DoctorName;
                doctorModel.Salary = doctor.Salary;

                doctorModels.Add(doctorModel);
            }
            return doctorModels;
        }
        public int  AddPatients(PatientModel patientModel)
        {
            Patient patient = new Patient();

            patient.DoctorId = patientModel.DoctorId;

            patient.PatientName = patientModel.PatientName;

            patient.PatientBill = patientModel.PatientBill;

            Business business = new Business();

             return business.AddPatients(patient);
        }
        public List<PatientModel> DisplayPatients(int id)
        {
            Business business = new Business();
            List<PatientModel> patient_Models = new List<PatientModel>();

            List<Patient> patients = business.DisplayPatients(id);

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


    }
    }