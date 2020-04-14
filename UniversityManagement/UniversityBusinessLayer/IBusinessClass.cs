using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityBusinessLayer
{
    public interface IBusinessClass
    {
        void AddUniversity(University university);
        List<University> ViewUniversities();



        void AddCollege(College college);
        List<College> ViewColleges();

        List<College> ViewAllColleges();


    }
}
