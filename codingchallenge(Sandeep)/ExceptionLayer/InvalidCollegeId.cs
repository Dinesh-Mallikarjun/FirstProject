using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLayer
{
    public class InvalidCollegeId : Exception
    {
        public InvalidCollegeId(string message , SqlException e) : base (message)
        {

        }
    }
}
