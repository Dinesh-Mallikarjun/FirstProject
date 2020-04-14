using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDataAccessLayer
{
    public class DataAccessClass:IDataAccessClass
    {
        UniversityContext dbContext = new UniversityContext();
        public void AddUniversity(University  university)
        { 
            try
            {
                dbContext.universities.Add(university);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<University> ViewUniversities()
        {
            var entities = dbContext.universities.ToList();
            return entities;
        }
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
        public List<College> ViewColleges()
        {
            var entities = dbContext.colleges.ToList();
            return entities;
        }
    
        public List<College> ViewAllColleges()
        {
            var entities = dbContext.colleges.ToList();
            return entities;
        }

    }
}
