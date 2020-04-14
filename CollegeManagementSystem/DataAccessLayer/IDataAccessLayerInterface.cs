using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public  interface IDataAccessLayerInterface
    {
        void AddCollege(College college);
        List<College> ViewColleges();

        void Apply(Student student);
        List<Student> ViewStudentForCollege(int id);

        College CheckEligibility(Student student);
        void Update(College college);
    }
}
