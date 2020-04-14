using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IBusinessClass
    {
        void AddCollege(College college);

        void AddStudent(Student student);

        List<Student> displaystudents(int id);

        List<College> DisplayColleges(College college);

        List<College> Display();

        List<Student> studentsbelow50();

        void delete(int id);
    }
}
