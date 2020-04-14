using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Business :IBusinessClass
    {
        public void AddCollege(College college )
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.AddCollege(college);
        }
        public void AddStudent(Student student)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.AddStudent(student);
        }
        public List<Student> displaystudents(int id)
        {
           DataAccess data = new DataAccess();
           return data.displaystudents(id);             
        }
        public List<College> DisplayColleges(College college)
        {
            DataAccess data = new DataAccess();
            return data.DisplayColleges(college);
        }
        public List<College> Display( )
        {
            DataAccess data = new DataAccess();
            return data.Display();
        }

        public List<Student> studentsbelow50()
        {
            DataAccess data = new DataAccess();
            return data.studentsbelow50();

        }

        public void delete(int id)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.delete(id);
        }

    }
}
