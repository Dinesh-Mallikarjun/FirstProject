using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capability
{
    class Program
    {

        public static Software[] addSoftware()
        {
            Console.WriteLine("Enter no of softwares you want to add");
            int size = Convert.ToInt32(Console.ReadLine());
            Software[] slist = new Software[size];
            Console.WriteLine("Enter SoftWare info");
            for (int i = 0; i < size; i++)
            {
                Software temp = new Software();
                Console.WriteLine("Enter id");
                temp.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Lisence No");
                temp.licencenumber = Console.ReadLine();
                Console.WriteLine("Enter name");
                temp.name = Console.ReadLine();
                Console.WriteLine("Enter Price");
                temp.cost = Convert.ToInt32(Console.ReadLine());
                slist[i] = temp;


            }

            return slist;
        }
        public static void disp(Software[] Slist)
        {
            Console.WriteLine("------------------------select licence number ---------------------");

            for (int i = 0; i < Slist.Length; i++)
            {
                Console.WriteLine(Slist[i].licencenumber);


            }
            //Console.WriteLine("----------------------------------------------");
        }
        public static void disp1(Software[] Slist)
        {
           // Console.WriteLine("-----------select Id number -----------");

            for (int i = 0; i < Slist.Length; i++)
            {
                Console.WriteLine(Slist[i].Id);


            }
            
        }
        public static Software validate(string s, Software[] slist)
        {

            for (int i = 0; i < slist.Length; i++)
            {
                if (slist[i].licencenumber.Equals(s))
                {
                    return slist[i];
                }
            }
            return null;
        }
        public static void Purchase(Software[] slist)
        {

            if (slist == null)
            {
                slist = addSoftware();
            }
            insertionSort(slist);
            disp(slist);
            Console.WriteLine("Enter Lisence no");
            string s = Console.ReadLine();
            Software temp = validate(s, slist);
            if (temp != null)
            {
                double gst = (5 * temp.cost) / 100;
                Console.WriteLine("TotalBill=" + (temp.cost + gst));

            }
            else
            {
                Console.WriteLine("Software not found");
            }
        }
        public static Software[] insertionSort(Software[] slist)
        {
            for (int i = 0; i < slist.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (slist[j].cost < slist[j - 1].cost)
                    {
                        Software temp = slist[j];
                        slist[j] = slist[j - 1];
                        slist[j - 1] = temp;
                    }
                }
            }
            return slist;
        }
        //public static Software[] bubbleSort(Software[] slist)
        //{
        //    for (int i = 0; i <= slist.Length; i++)
        //    {
        //        for (int j = 0; j < slist.Length - i - 1; j++)
        //        {
        //            if (slist[j].cost > slist[j + 1].cost)
        //            {
        //                Software temp = slist[j];
        //                slist[j] = slist[j + 1];
        //                slist[j + 1] = temp;
        //            }
        //        }
        //    }
        //    return slist;
        //}
        public static Software[] bubbleSortid(Software[] slist)
        {
            int size = slist.Length;

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (slist[j].Id > slist[j + 1].Id)
                    {
                        Software temp = slist[j];
                        slist[j] = slist[j + 1];
                        slist[j + 1] = temp;
                    }
                }
            }
            return slist;
        }
        public static void binarySearch(Software[] slist)
        {
            if (slist == null)
            {
                slist = addSoftware();
            }
            
            Console.WriteLine("after bubble sort");
            slist = bubbleSortid(slist);
            Console.WriteLine("Enter Software id to found");
            disp1(slist);
            int id = Convert.ToInt32(Console.ReadLine());
          
            int start = 0;
            int last = slist.Length - 1;
            int mid = (last + start) / 2;
            while (last >= 0 && start <= slist.Length - 1)
            {
                mid = (last + start) / 2;
                if (slist[mid].Id == id)
                {
                    Console.WriteLine("Found at index=" + mid);
                    Console.WriteLine(slist[mid].name);
                    return;
                }
                else if (id > slist[mid].Id)
                {
                    start = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }

            }
            Console.WriteLine("Software Not Found");
        }
        static void Main(string[] args)
        {
            bool flag = true;
            Software[] slist = null;
            while (flag)
            {

                Console.WriteLine("Enter Choice\n 1 Add Softwares\n 2 to Purchase\n 3  Search\n 4 Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: slist = addSoftware();
                            break;
                    case 2: Purchase(slist);
                            break;
                    case 3: binarySearch(slist);
                            break;
                    case 4:
                            flag = false;
                            Console.WriteLine("Thank you");
                            Console.ReadKey();
                            break;
                }

            }
        }
    }
}