using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementPresentationLayer
{
    class Library
    {
        static void Main(string[] args)
        {
            bool flag = true;

            do
            {
                Console.WriteLine("Enter your choice:\n 1.Add books\n 2.display books");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You have chosen invalid choice , please choose valid choice");
                        break;

                }
            } while (flag);

        }
        static int 
    }
}
