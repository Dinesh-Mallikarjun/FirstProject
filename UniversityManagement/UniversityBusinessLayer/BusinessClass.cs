using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityDataAccessLayer;

namespace UniversityBusinessLayer
{
    public class BusinessClass :IBusinessClass
    {
        private IDataAccessClass   _dataAccessClass;

        public void AddUniversity(University university )
        {
            _dataAccessClass = new DataAccessClass();
            try
            {
                _dataAccessClass.AddUniversity(university);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<University> ViewUniversities()
        {
            _dataAccessClass = new DataAccessClass();
            List<University> universities = _dataAccessClass.ViewUniversities();
            return universities;
        }


        public void AddCollege(College college)
        {
            _dataAccessClass = new DataAccessClass();
            

            try
            {
                _dataAccessClass.AddCollege(college);
            }
            catch(Exception)
            {
                throw;
            }
        }
        public List<College> ViewColleges()
        {
            _dataAccessClass = new DataAccessClass();
            List<College> colleges = _dataAccessClass.ViewColleges();
            return colleges;
        }

        public List<College> ViewAllColleges()
        {
            _dataAccessClass = new DataAccessClass();
            List<College> allColleges = _dataAccessClass.ViewAllColleges();
            List<College> colleges = new List<College>();
            foreach(College college in allColleges)
            {
                if (college.totalStudents > 2)
                    colleges.Add(college);
            }
            return colleges;
        }


    }

}

