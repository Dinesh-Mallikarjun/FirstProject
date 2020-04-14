using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityBusinessLayer;

namespace UniversityPresentationLayer.Models
{
    public class ModelManager
    {

        private IBusinessClass _IbusinessClass;

        public Exception CollegeCountExceededException { get; private set; }

        public void AddUniversity(UniversityModel universitymodel)
        {
            _IbusinessClass = new BusinessClass();

            University university = new University();
            university.universityName = universitymodel.universityName;
            university.totalColleges = universitymodel.totalColleges;

            try
            {
                _IbusinessClass.AddUniversity(university);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<UniversityModel> ViewUniversities()
        {
            _IbusinessClass = new BusinessClass();
            List<UniversityModel> universityModels = new List<UniversityModel>();
            List<University> universities = _IbusinessClass.ViewUniversities();
            foreach (University university in universities)
            {
                UniversityModel universityModel = new UniversityModel();
                universityModel.universityId = university.universityId;
                universityModel.universityName = university.universityName;
                universityModel.totalColleges = university.totalColleges;


                universityModels.Add(universityModel);
                universityModels.Sort();
            }
            return universityModels;
        }
        public void AddCollege(CollegeModel collegeModel)
        {
            _IbusinessClass = new BusinessClass();

            College college = new College();
            college.collegeName = collegeModel.collegeName;
            college.totalStudents = collegeModel.totalStudents;
            college.UniversityId = collegeModel.UniversityId;

            try
            {
                _IbusinessClass.AddCollege(college);
            }
            catch
            {
                throw CollegeCountExceededException;
            }
        }

        public List<CollegeModel> ViewColleges()
        {
            _IbusinessClass = new BusinessClass();
            List<CollegeModel> collegeModels = new List<CollegeModel>();
            List<College> colleges = _IbusinessClass.ViewColleges();
            foreach (College college in colleges)
            {
                CollegeModel collegeModel = new CollegeModel();
                collegeModel.collegeId = college.collegeId;
                collegeModel.collegeName = college.collegeName;
                collegeModel.totalStudents = college.totalStudents;
                collegeModel.UniversityId = college.UniversityId;


                collegeModels.Add(collegeModel);
                //collegeModels.Sort();
            }
            return collegeModels;
        }

        public List<CollegeModel> ViewAllColleges()
        {
            _IbusinessClass = new BusinessClass();
            List<CollegeModel> allcollegeModels = new List<CollegeModel>();
            List<College> allcolleges = _IbusinessClass.ViewAllColleges();
            foreach (College college in allcolleges)
            {
                CollegeModel allcollegeModel = new CollegeModel();
                allcollegeModel.collegeId = college.collegeId;
                allcollegeModel.collegeName = college.collegeName;
                allcollegeModel.totalStudents = college.totalStudents;
                allcollegeModel.UniversityId = college.UniversityId;

                allcollegeModels.Add(allcollegeModel);
            }
                return allcollegeModels;
        }

    }
}