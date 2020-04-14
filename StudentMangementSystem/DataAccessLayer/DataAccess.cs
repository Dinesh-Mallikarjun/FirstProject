//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccessLayer
//{
//    public class DataAccess
//    {
//    }
//}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using StudentMangementSystem;

namespace DataAccessLayer
{
    public class DataAccess
    {
        public void InsertToData(college college)
        {
            using (collegeManagementEntities collegeManagement = new collegeManagementEntities())
            {
                collegeManagement.colleges.Add(college);

                collegeManagement.SaveChanges();
            }

        }
        public List<college> dispalycollege()
        {
            using (collegeManagementEntities collegeManagement = new collegeManagementEntities())
            {
                List<college> list = new List<college>();

                list = collegeManagement.colleges.ToList();
                collegeManagement.SaveChanges();
                return list;
            }

        }

        public college Check(int? id)
        {

            using (collegeManagementEntities collegeManagement = new collegeManagementEntities())
            {
                //college college = new college();
                var college = collegeManagement.colleges.Where(x => x.Collegeid == id).Single();
                return college;
            }
        }

        public void AddStudent(student student)
        {
            using (collegeManagementEntities collegeManagement = new collegeManagementEntities())
            {
                collegeManagement.students.Add(student);
                collegeManagement.SaveChanges();

                var i = collegeManagement.colleges.Single(x => x.Collegeid == student.Collegeid);
                i.NumberofseatsAvailable = i.NumberofseatsAvailable - 1;
                collegeManagement.SaveChanges();
            }
        }
        public List<student> displayStudent(int id)
        {
            using (collegeManagementEntities collegeManagement = new collegeManagementEntities())
            {
                List<student> list = new List<student>();
                list = collegeManagement.students.Where(x => x.Collegeid == id).ToList();
                return list;
            }
        }
    }
}
