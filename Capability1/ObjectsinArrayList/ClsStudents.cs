using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsinArrayList
{
    class ClsStudents
    {
        public int studentId;
        public string FirstName;
        public string LastName;
        private int sId;
        private int sFName;
        private int sLName;

        public ClsStudents(int a,string b , string c)
        {
            studentId = a;
            FirstName = b;
            LastName = c;
        }

        public ClsStudents(int sId, int sFName, int sLName)
        {
            this.sId = sId;
            this.sFName = sFName;
            this.sLName = sLName;
        }
    }
}
