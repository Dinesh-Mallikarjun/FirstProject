using CollegeManagementEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementBusinessLayer
{
    interface ICollegeManagementBusinessLayerClass
    {
        void AddCollege(College college);
        List<College> DisplayStudents();

        
    }
}
