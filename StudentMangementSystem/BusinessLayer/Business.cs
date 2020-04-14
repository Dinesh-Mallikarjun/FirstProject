//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessLayer
//{
//    public class Business
//    {
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using StudentMangementSystem;

namespace BusinessLayer
{
    public class Business
    {
        public void InsertCollege(college college)
        {
            DataAccess data = new DataAccess();
            data.InsertToData(college);
        }
        public List<college> displaycollege()
        {
            DataAccess data = new DataAccess();
            return data.dispalycollege();
        }
        public bool AddStudent(student student)
        {
            college college = new college();
            DataAccess data = new DataAccess();
            college = data.Check(student.Collegeid);
            if (student.PercentageObtained >= college.cutOffPercentage && college.NumberofseatsAvailable > 0)
            {
                data.AddStudent(student);
                return true;
            }
            return false;

        }

        public List<student> DisplayStudent(int id)
        {
            DataAccess data = new DataAccess();
            return data.displayStudent(id);
        }
    }
}
