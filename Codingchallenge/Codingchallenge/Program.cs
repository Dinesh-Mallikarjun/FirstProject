using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingchallenge
{   
    class Software
    {
       public int id { get; set; }
       double licensenumber { get; set; }
       string name { get; set; }
       int cost { get; set; }

        internal object getCost()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice \n1.add software\n2.purchase software\n3.Binary search");
            bool flag = true;
            while(flag)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1: addSoftware();
                        Console.WriteLine("Software added succesfully");
                        break;
                    case 2:
                        purchaseSoftware();
                        break;
                    case 3:
                        binarySearch();
                        break;
                    case 4:
                        Console.WriteLine("Thank you....");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

       
            public static bool binarySearchNum(Software[] s, int first, int last, int key)
            {
                while (first <= last)
                {
                    int mid = (first + last) / 2;

                    if (Software[mid] < key)
                    {
                        first = mid + 1;
                        Console.WriteLine("Element found at index of");
                        return binarySearchNum(s, first, last, key);
                    }
                    else if (Software[mid] == key)
                    {
                        return true;
                    }
                    else
                    {
                        first = mid - 1;
                      Console.WriteLine(binarySearchNum(s, first, last, key));
                    }
                }
                if (first > last)
                {
                    Console.WriteLine("Element is not found:");
                }
                return false;
            }




        }

        private static int  PurchaseSoftware(Software[] s , int size)
        {

        
            int i, j, temp;
            bool swapped;
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size - i - 1; j++)
                {
                    if (Software[j] > Software[j + 1])
                    {
                        temp = software[j];
                        Software[j] = Software[j + 1];
                        Array[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped = false)
                    break;
            }
    return Software;
    
    /*
       
            for (int a = 1; a < s.Length; a++)
            {
                for (int b = 0; b < s.Length - a; b++)
                {
                int temp = 0;
                    if (((s[b].getCost()).CompareTo()((s[b + 1].getCost()))) > 0)
                        
                     s temp = s[b];
                    s[b] = s[b + 1];
                    s[b + 1] = temp;
                }
            }
        }


    */

    }

        

        private static void addSoftware()
        {
            Software sw = new Software();
            Console.WriteLine("Enter the number of software:");
            int size = Convert.ToInt32(Console.ReadLine());
            Software[] s = new Software[size];

            Console.WriteLine("Enter id :");
            int softid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter license number :");
            double licensenum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string softname = Console.ReadLine();
            Console.WriteLine("Enter cost");
            int softcost = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();


            //throw new NotImplementedException();


        }

    }

