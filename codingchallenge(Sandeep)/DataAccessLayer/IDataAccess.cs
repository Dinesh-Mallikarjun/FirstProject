using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataAccess
    {
        void AddCollege(College college);
        List<College> DisplayColleges(College college);

        void AddStudent(Student student);
        List<Student> displaystudents(int id);

        List<College> Display();

        //List<College> colleges(College college);
        List<Student> studentsbelow50();

        void delete(int id);
    }
}
