using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ModelManager
    {
        static Business business = new Business();
        public void ApplyJob(ApplyForJobModel applyForJobModel)
        {
            ApplyForjob applyForjob = new ApplyForjob();
            applyForJobModel.CompanyName = "Mindtree";
            applyForjob.CompanyName = applyForJobModel.CompanyName;
            applyForjob.CandidatName = applyForJobModel.CandidatName;
            applyForjob.mobileNumber = applyForJobModel.mobileNumber;
            applyForjob.Email = applyForJobModel.Email;
            applyForjob.Contact = new Contact();
            applyForjob.Contact.ContactId = applyForJobModel.Contact.ContactId;
            applyForjob.Gender = new Gender();
            applyForjob.Gender.GenderId = applyForJobModel.Gender.GenderId;
            applyForjob.CurrentRole = applyForJobModel.CurrentRole;
            applyForjob.collegename = applyForJobModel.collegename;
            applyForjob.PreOrgName = applyForJobModel.PreOrgName;
            business.Applyjob(applyForjob);
        }
        public List<GenderModel> DisplayGenders()
        {
            List<GenderModel> genderModels = new List<GenderModel>();
            List<Gender> genders = business.DisplayGenders();
            foreach(var gender in genders)
            {
                GenderModel genderModel = new GenderModel();
                genderModel.GenderId = gender.GenderId;
                genderModel.GenderName = gender.GenderName;
                genderModels.Add(genderModel);
            }
            return genderModels;
        }
        public List<ContactModel> DisplayContacts()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            List<Contact> contacts = business.DisplayContacts();
            foreach (var contact in contacts)
            {
                ContactModel contactModel = new ContactModel();
                contactModel.ContactId = contact.ContactId;
                contactModel.ContactedBy = contact.ContactedBy;
                contactModels.Add(contactModel);
            }
            return contactModels;
        }
        public List<ApplyForJobModel> DisplayApplications()
        {
            List<ApplyForJobModel> applyForJobModels = new List<ApplyForJobModel>();
            List<ApplyForjob> applyForjobs = business.DisplayApplications();
            foreach(var application in applyForjobs)
            {
                ApplyForJobModel applyForJobModel = new ApplyForJobModel();
                applyForJobModel.CompanyName = application.CompanyName;
                applyForJobModel.CandidatName = application.CandidatName;
                applyForJobModel.mobileNumber = application.mobileNumber;
                applyForJobModel.Email = application.Email;
                applyForJobModel.Contact = new ContactModel();
                applyForJobModel.Contact.ContactedBy = application.Contact.ContactedBy;
                applyForJobModel.Gender = new GenderModel();
                applyForJobModel.Gender.GenderName = application.Gender.GenderName;
                applyForJobModel.CurrentRole = application.CurrentRole;
                applyForJobModel.collegename = application.collegename;
                applyForJobModel.PreOrgName = application.PreOrgName;
                applyForJobModels.Add(applyForJobModel);
            }
            return applyForJobModels;
        }
    }
}