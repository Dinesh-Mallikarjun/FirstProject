using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IBusinessLayerInterface
    {
        void AddCollege(College college);

        List<College> ViewColleges();

        int Apply(Student student);

        List<Student> ViewStudentForCollege(int id);
    }
}
