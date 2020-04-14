using System;


namespace ArrayOfObject
{
    class Student
    {
        public static StudentDetails[] addInput()
        {
            Console.WriteLine("Enter the number of students you want to add:");
            int size = Convert.ToInt32(Console.ReadLine());

            StudentDetails[] sDetails = new StudentDetails[size];

            Console.WriteLine("Enter student information:");
            StudentDetails obj = new StudentDetails();

            for (int i = 0; i < size; i++)
            {
         
                Console.WriteLine("enter the student name ");
                string name = obj.setName();
               

                Console.WriteLine("Enter roll number of student");
                int rollno = obj.setRollno();
                
                Console.WriteLine("Enter marks of the students ");
                int marks = obj.setMarks();

                sDetails[i] = obj;
            }
            return sDetails;
        }
        /*
      public  static void showDetails(StudentDetails[] SDetails)
        {
            Console.WriteLine("-----Student details-----");
            Console.ReadKey();
            SDetails = addInput();
            for(int i=0;i<SDetails.Length;i++)
            {
                Console.WriteLine("Student name is :"+SDetails[i].getName());
                Console.WriteLine("Student roll number  is :" + SDetails[i].getRollno());
                Console.WriteLine("Student marks :" + SDetails[i].getMarks());
                Console.ReadKey();
            }
        }*/
        static void Main(string[] args)
        {
        Start:
            bool flag = true;
            do
            {
                Console.WriteLine("Enter your choice :\n 1.add student details \n 2. show student details");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addInput();
                        break;
                    case 2:
                      //  Student.showDetails(StudentDetails.SDetails);
                        break;
                    case 3:
                        flag = false;
                        Console.WriteLine("Thank you ");
                        break;
                    default:
                        Console.WriteLine("You entered invalid choice please enter valid choice");
                        goto Start;

                }

            } while (flag);
        }
    }
}
