using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer;
using Entities;


namespace PresentationLayer.Models
{
    public class ModelManager
    {
        private IBusinessLayerInterface _businessLayerInterface;

        public void AddCollege(CollegeModel collegeModel)
        {
            _businessLayerInterface = new BusinessLayerClass();

            College college = new College();
            college.collegeName = collegeModel.collegeName;
            college.location = collegeModel.location;
            college.CutOffPercentage = collegeModel.CutOffPercentage;
            college.AvailableSeat = collegeModel.AvailableSeat;

            try
            {
                _businessLayerInterface.AddCollege(college);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<CollegeModel> ViewColleges()
        {
            _businessLayerInterface = new BusinessLayerClass();
            List<CollegeModel> collegeModels = new List<CollegeModel>();
            List<College> colleges = _businessLayerInterface.ViewColleges();
            foreach(College college in colleges)
            {
                CollegeModel collegeModel = new CollegeModel();
                collegeModel.collegeId = college.collegeId;
                collegeModel.collegeName = college.collegeName;
                collegeModel.CutOffPercentage = college.CutOffPercentage;
                collegeModel.location = college.location;
                collegeModel.AvailableSeat = college.AvailableSeat;

                collegeModels.Add(collegeModel);
                collegeModels.Sort();
            }
            return collegeModels;
        }
        public List<StudentModel> ViewStudentForCollege(int id)
        {
            _businessLayerInterface = new BusinessLayerClass();
            List<Student> students = new List<Student>();

            if(students!=null)
            {
                List<StudentModel> studentModels = new List<StudentModel>();
                foreach (Student student in students)
                {
                    StudentModel studentModel = new StudentModel();
                    studentModel.id = student.id;
                    studentModel.Name = student.Name;
                    studentModel.percentage = student.percentage;
                    studentModel.CollegeId = student.CollegeId;

                    studentModels.Add(studentModel);
                }
                return studentModels;
            }
            return null;
           
        }

        public int Apply (StudentModel studentModel)
        {
            _businessLayerInterface = new BusinessLayerClass();
            Student student = new Student();
            student.Name = studentModel.Name;
            student.percentage = studentModel.percentage;
            student.CollegeId = studentModel.CollegeId;




            int i = _businessLayerInterface.Apply(student);
            return i;
        }
    }
}