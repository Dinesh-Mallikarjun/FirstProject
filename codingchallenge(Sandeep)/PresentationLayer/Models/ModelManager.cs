using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.Models
{
    public class ModelManager
    {

        public void AddCollege(CollegeModel collegeModel )
        {
            College college = new College();
            //Mapping
            college.CollegeName = collegeModel.CollegeName;
            college.CutOff = collegeModel.CutOff;
            college.Location = collegeModel.Location;
            college.NoOfAvailableSeats = collegeModel.NoOfAvailableSeats;
            //Sending data to business
            Business business = new Business();
            business.AddCollege(college);
        }
        public void AddStudent(StudentModel studentModel)
        {
            Student student = new Student();
            //Mapping
            student.StudentName = studentModel.StudentName;
            student.ObtainedPercentage = studentModel.ObtainedPercentage;
            student.CollegeId = studentModel.CollegeId;
            //Sending data to business
            Business business = new Business();
            business.AddStudent(student);
        }
        //public void DisplayColleges(CollegeModel collegeModel)
        //{
        //    Business business = new Business();
        //    List<CollegeModel> collegeModels = new List<CollegeModel>();
        //    List<College> colleges = business.DisplayColleges(collegeModel);
        //    foreach(var college in colleges)
        //    {
        //        CollegeModel collegeModel = new CollegeModel();

        //    }
        //}
        public List<StudentModel> displaystudents(int id)
        {
            Business business = new Business();
            List<StudentModel> studentModels = new List<StudentModel>();
            List<Student> students = business.displaystudents(id);

            foreach (var student in students)
            {
                StudentModel studentModel = new StudentModel();

                studentModel.Studentid = student.Studentid;
                studentModel.StudentName = student.StudentName;
                studentModel.ObtainedPercentage = student.ObtainedPercentage;
                studentModel.CollegeId = student.CollegeId;  
                studentModels.Add(studentModel);
            }
            return studentModels;
        }

        public List<CollegeModel> Display( )
        {
            Business business = new Business();
            List<CollegeModel> collegeModels = new List<CollegeModel>();
            List<College> colleges = business.Display();

            foreach (var college in colleges)
            {
                CollegeModel collegeModel = new CollegeModel();

                collegeModel.CollegeId = college.CollegeId;
                collegeModel.CollegeName = college.CollegeName;
                collegeModel.CutOff = college.CutOff;
                collegeModel.Location = college.Location;
                collegeModel.NoOfAvailableSeats = college.NoOfAvailableSeats;
                if(collegeModel.NoOfAvailableSeats>0)
                {
                    collegeModels.Add(collegeModel);
                }
                
            }
            return collegeModels;
        }


        public List<StudentModel> studentsbelow50()
        {
            Business business = new Business();
            List<StudentModel> studentModels = new List<StudentModel>();
            List<Student> students = business.studentsbelow50();

            foreach (var student in students)
            {
                StudentModel studentModel = new StudentModel();

                studentModel.Studentid = student.Studentid;
                studentModel.StudentName = student.StudentName;
                studentModel.ObtainedPercentage = student.ObtainedPercentage;
                studentModel.CollegeId = student.CollegeId;
                studentModels.Add(studentModel);
            }
            return studentModels;
        }


        public void delete( int id)
        {
            Student student = new Student();
            Business business = new Business();
            business.delete(id);
        }



    }
}