//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace StudentMangementSystem.Models
//{
//    public class ModelManager
//    {
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentMangementSystem;
using EntityLayer;
using BusinessLayer;
using StudentMangementSystem;
using StudentMangementSystem.Models;

namespace StudentMangementSystem.Models
{
    public class ModelManager
    {
        public void InsertCollege(CollegeEntity collegeEntity)
        {

            college c = new college();
            c = collegeEntity.college;
            Business business = new Business();
            business.InsertCollege(c);

        }
        public List<CollegeEntity> displayCollege()
        {
            Business business = new Business();
            List<CollegeEntity> modellist = new List<CollegeEntity>();

            List<college> list = new List<college>();
            list = business.displaycollege();
            foreach (var i in list)
            {
                CollegeEntity ce = new CollegeEntity();
                ce.college = new    college();
                ce.college = i;
                modellist.Add(ce);
            }
            return modellist;
        }

        public bool AddStudent(StudentEnt studentEnt)
        {

            student student = new student();
            student = studentEnt.student;
            Business business = new Business();
            return business.AddStudent(student);


        }

        public List<StudentEnt> displaystudent(int collegeid)
        {
            Business business = new Business();
            List<StudentEnt> list = new List<StudentEnt>();
            foreach (var i in business.DisplayStudent(collegeid))
            {
                StudentEnt student = new StudentEnt();
                student.student = new student();
                student.student = i;
                list.Add(student);
            }
            return list;

        }
    }
}