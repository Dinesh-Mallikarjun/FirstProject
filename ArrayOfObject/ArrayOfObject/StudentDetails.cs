using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObject
{
    class StudentDetails
    {

        private string name;
        private int rollno;
        private int marks;
        internal static StudentDetails[] SDetails;

        public string setName()
         {   
             string name = Console.ReadLine();
             return name;
         }
         public string getName()
         {
             return name;
         }
         public int setRollno()
         {
             int rollno = Convert.ToInt32(Console.ReadLine());
             return rollno;
         }
         public int getRollno()
         {
             return rollno;
         }
         public int setMarks()
         {
             int marks = Convert.ToInt32(Console.ReadLine());
             return marks;
         }
         public int getMarks()
         {
             return marks;
         }





    }
}
