using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccess
    {
        CompanyEntities companyEntities = new CompanyEntities();
        public void Applyjob(ApplyForjob applyForjob)
        {
            var result = companyEntities.Genders.SingleOrDefault(g => g.GenderId == applyForjob.Gender.GenderId);
            var result2 = companyEntities.Contacts.SingleOrDefault(c => c.ContactId == applyForjob.Contact.ContactId);
            applyForjob.Gender = result;
            applyForjob.Contact = result2;
            ApplyForjob applyjob = companyEntities.ApplyForjobs.Add(applyForjob);
            companyEntities.SaveChanges();
        }
        public List<Gender> DisplayGenders()
        {
            return companyEntities.Genders.ToList();
        }
        public List<Contact> DisplayContacts()
        {
            return companyEntities.Contacts.ToList();
        }
        public List<ApplyForjob> DisplayApplications()
        {
            return companyEntities.ApplyForjobs.ToList();
        }
    }
}