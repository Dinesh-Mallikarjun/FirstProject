using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsinArrayList
{
    class Program


    {
        static ArrayList al = new ArrayList();
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("Enter your choice \n1.add student\n2.get student\n3.remove student \n4.display student");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        addStudent();
                        break;
                    case 2:
                        getStudent();
                        break;
                    case 3:
                        removeStudent();
                        break;
                    case 4:
                        display();
                        break;
                    case 5:
                        i = 0;

                        break;
                    default:
                        Console.WriteLine("inavlid choice");
                        break;
                }
            }
            while (i != 0);
        }
        public static void getStudent()
        {
            Console.WriteLine("Enter student id");
            int Id = Convert.ToInt32(Console.ReadLine());
            foreach(ClsStudents i in al)
            {
                if(i.studentId==Id)
                {
                    Console.WriteLine("Student name is "+i.FirstName+" "+i.LastName+ "+\n student id is+" +i.studentId);
                }
            }
        }
        public static void display()
        {
            foreach (ClsStudents i in al)
            {
                Console.WriteLine(i.FirstName + " " + i.LastName + " " + i.studentId);
            }
        }
        public static void removeStudent()
        {
            Console.WriteLine("Enter name of the student ");
            string name = Console.ReadLine();

            foreach(ClsStudents i in al)
            {
                if(i.FirstName.Equals(name))
                {
                    al.Remove(i);
                    break;
                }
            }

        }
        public static void addStudent()
        {
            Console.WriteLine("Enter id of the student ");
            int sId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first name of the student ");
            string sFName = Console.ReadLine();
            Console.WriteLine("Enter last name of the student ");
            string sLName = Console.ReadLine();
            ClsStudents ob1 = new ClsStudents(sId, sFName, sLName);
            al.Add((Object)ob1);

        }




    }
}
