using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccessLayerClass :IDataAccessLayerInterface
    {
        MyDbContext dbContext = new MyDbContext();

        public void AddCollege(College college)
        {
            try
            {
                dbContext.colleges.Add(college);
                dbContext.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void Apply(Student student)
        {
            try
            {
                dbContext.students.Add(student);
                dbContext.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public College CheckEligibility(Student student)
        {
            var entity = dbContext.colleges.Where(c => c.collegeId == student.CollegeId).FirstOrDefault();
            return entity;
        }
        public void Update(College college)
        {
            var entity = dbContext.colleges.Where(c => c.collegeId == college.collegeId).FirstOrDefault();
            entity.AvailableSeat = entity.AvailableSeat - 1;
            dbContext.SaveChanges();
        }
        public List<College> ViewColleges()
        {
            // var entities = dbContext.colleges.ToList();
            // return entities;
           var entities= dbContext.colleges.ToList();
            return entities;
        }
        public List<Student> ViewStudentForCollege(int id)
        {
            var entity = dbContext.students.Where(s => s.CollegeId == id).ToList();
            return entity;
        }
    }
}
