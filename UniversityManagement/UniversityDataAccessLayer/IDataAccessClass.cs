using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace UniversityDataAccessLayer
{
    public interface IDataAccessClass
    {
        void AddUniversity(University university);

        List<University> ViewUniversities();



        void AddCollege(College college);
        //int getCollegesNumber(College college);
        List<College> ViewColleges();


        List<College> ViewAllColleges();
    }
}
