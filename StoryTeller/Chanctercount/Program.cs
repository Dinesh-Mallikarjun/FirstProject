using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanctercount
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Enter choice 1.bubble sort \n 2.binary search");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a size of an array");
                        int size = Convert.ToInt32(Console.ReadLine());
                        int[] arr = new int[size];
                        Console.WriteLine("Enter elements of an array");
                        for (int i = 0; i < size; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        bubbleSort(arr);
                        Console.ReadKey();
                        printArray(arr);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Enter  size of an array");
                        int size1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter elements of an array");
                        int[] arr1 = new int[size1];
                        for (int i = 0; i < size1; i++)
                        {
                            arr1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        bubbleSort(arr1);
                        Console.WriteLine(arr1);
                        int first = arr1[0];
                        int last = arr1.Length - 1;
                        Console.WriteLine("Enter the element to find");
                        int key = Convert.ToInt32(Console.ReadLine());
                        binarySearch(arr1, first, last, key);
                        Console.ReadKey();
                        printArray(arr1);
                        Console.ReadKey();


                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            } while (flag);
       }
        static void bubbleSort(int[] arr)
        {
            int size = arr.Length;

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void printArray(int []arr)
        {

            int size = arr.Length;
            for(int i=0;i<size;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
     
        }

        static int  binarySearch(int []arr1,int first,int last , int key)
        {

            while (first <= last)
            {
                int mid = first + (last - first) / 2;
                if (arr1[mid] == key)
                    return mid;
                if (arr1[mid] > key)
                    return binarySearch(arr1, first, mid - 1, key);
                   // last = mid - 1;
                if (arr1[mid] < key)
                    return binarySearch(arr1, mid +1, last, key);
                //first = mid + 1;

            }
            return -1;
            if (first > last)
            {
                Console.WriteLine("Element is not found:");
            }





        }
    }
}
