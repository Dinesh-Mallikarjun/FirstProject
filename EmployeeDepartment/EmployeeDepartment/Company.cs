using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepartment
{
    class Company
    {
        static Department dep;

        static Employee emp;
        List<Employee> employeeList;
        List<Department> departmentList;

        static void Main(string[] args)
        {
            Employee e = new Employee();
            bool flag = true;
            do
            {
                Console.WriteLine("Enter your choice:\n1.Add Employees to a particular department\n2.Display departments\n3.display total employee in each departments\n4.search particular employee\n5.sort employees\n6.exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:                        
                        emp=AddEmployee(e);
                        break;
                    case 2:
                     
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice please enter valid choice");
                        break;
                }

            } while (flag);
        }

        public static void AddEmployee()
        {
            Console.WriteLine("Enter total number of departments");
            int totaldepartment = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < totaldepartment; i++)
            {
                Department dept = new Department();
                Console.WriteLine("Enter departmentid");
                int deptId = Convert.ToInt32(Console.ReadLine());

                dept.DepartmentId = deptId;
           
                Console.WriteLine("Enter department name of employee");
                string deptName = Console.ReadLine();
                dept.DepartmentName = deptName;

                List<Employee> emp = new List<Employee>();

                Console.WriteLine("Enter total number of employees you want to add in that particular department");
                int noOfEmployees = Convert.ToInt32(Console.ReadLine());

                for (int k = 0; k < noOfEmployees; k++) ;
                { 
                Employee empl  = new Employee();
                Console.WriteLine("Enter id of employee");
                int Id = Convert.ToInt32(Console.ReadLine());
                empl.EmpId = Id;
         
                Console.WriteLine("Enter name of employee");
                string Name = Console.ReadLine();
                empl.EmpName = Name;
                Console.WriteLine("Enter father name of employee");
                string FName = Console.ReadLine();
                empl.FatherName = FName;
                Console.WriteLine("Enter age of employee");
                int age = Convert.ToInt32(Console.ReadLine());
                empl.Age = age;
                Console.WriteLine("Enter salary of employee");
                int salary = Convert.ToInt32(Console.ReadLine());
                empl.Salary = salary;

                                 
            }
            
        }
         void DisplayEmployees()
        {

            Console.WriteLine("----details of employees");
            
            Console.WriteLine("Employee id : " +emp.EmpId );
            Console.WriteLine("Employee name : " + emp.EmpName);
            Console.WriteLine("Father name : " + emp.FatherName);
            Console.WriteLine("salary : " + emp.Salary);
            Console.WriteLine("Department id :" + emp.DepartmentId);
            Console.WriteLine("Department name:" + emp.DepartmentName);
            Console.ReadKey();

        }
    }
}
