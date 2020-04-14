using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessLayerClass : IBusinessLayerInterface
    {
        private IDataAccessLayerInterface _dataAccessLayerInterface;

        public void AddCollege(College college)
        {
            _dataAccessLayerInterface = new DataAccessLayerClass();
            try
            {
                _dataAccessLayerInterface.AddCollege(college);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int Apply(Student student)
        {
            bool flag = false;

            _dataAccessLayerInterface = new DataAccessLayerClass();
            List<College> colleges = ViewColleges();
            foreach (College newCollege in colleges)
            {
                if (newCollege.collegeId == student.CollegeId)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                College college = _dataAccessLayerInterface.CheckEligibility(student);
                if (student.percentage > college.CutOffPercentage)
                    try
                    {
                        _dataAccessLayerInterface.Apply(student);
                        _dataAccessLayerInterface.Update(college);
                        return college.collegeId;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                else
                    return 0;
            }
            else
                return 0;
        }


        public List<College> ViewColleges()
        {
            _dataAccessLayerInterface = new DataAccessLayerClass();
            List<College> colleges = _dataAccessLayerInterface.ViewColleges();
            return colleges;
        }

        public List<Student> ViewStudentForCollege(int id)
        {
            _dataAccessLayerInterface = new DataAccessLayerClass();
            bool flag = false;
            List<College> colleges = ViewColleges();
            foreach (College newCollege in colleges)
            {
                if (newCollege.collegeId == id)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                List<Student> students = _dataAccessLayerInterface.ViewStudentForCollege(id);
                return students;
            }
            return null;
        }
    }
}
