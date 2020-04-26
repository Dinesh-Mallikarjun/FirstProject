using DataAccessLayer;
using EntityLayer;
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
        public void Applyjob(ApplyForjob applyForjob)
        {
            dataAccess.Applyjob(applyForjob);
        }
        public List<Contact> DisplayContacts()
        {
            return dataAccess.DisplayContacts();
        }
        public List<Gender> DisplayGenders()
        {
            return dataAccess.DisplayGenders();
        }
        public List<ApplyForjob> DisplayApplications()
        {
            return dataAccess.DisplayApplications();
        }
    }
}
