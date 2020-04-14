using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Operation
    {
        static List<MobileOpearator> list = new List<MobileOpearator>();
        static List<Person> list1 = new List<Person>();
        static void Main(string[] args)
        {
            int loopCounter = 1;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter choice \n 1. to add mobile opeartor entity \n 2.to display all mobile operator with id and nam\n 3. add the person entity \n 4.to display top 2 mobile operator by rating \n 5.to serach person details with mobile operator using person id \n to display all person name in a text file \n to exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addMobileOperator();
                        break;
                    case 2:
                        displayMobileOperator();
                        break;
                    case 3:
                        addPerson();
                        break;
                    case 4:
                        displayTopTwoOperator();
                        break;
                    case 5:
                        displayPerson();
                        break;
                    case 6:
                        addToFile();
                        break;

                    case 7:
                        loopCounter = 0;
                        Console.WriteLine("Thank you");
                        Console.ReadLine();
                        break;
                }
            }
            while (loopCounter != 0);
        }
        public static void displayTopTwoOperator()
        {
            double max1 = 0, max2 = 0;
            string name = "", name1 = "";
            foreach (MobileOpearator mo in list)
            {
                if (mo.rating > max1)
                {
                    max2 = max1;
                    max1 = mo.rating;
                    name = mo.name;
                }
                else if (max2 > mo.rating && mo.rating != max1)
                {
                    max2 = mo.rating;
                    name1 = mo.name;
                }
            }
            Console.WriteLine("Maximum rated operator name {0} , and rating is {1}", name, max1);

            Console.WriteLine("second Maximum rated operator name {0} , and rating is {1}", name, max2);

        }
        public static void addPerson()
        {
            Person p = new Person();
            Console.WriteLine("Enter the person id ");
            int pId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the person name ");
            string pName = Console.ReadLine();
            Console.WriteLine("Enter the mobile operator id  ");
            int mId = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            int flag = 0;
            try
            {
                foreach (Person person in list1)
                {
                    if (person.Personid == pId)
                    {
                        throw new DuplicatePersonException("person id shoud not be same");
                    }
                }
            }
            catch (DuplicateWaitObjectException e)
            {
                flag = 1;
                Console.WriteLine(e.Message);

            }
            if (flag != 1)
            {
                try
                {
                    foreach (MobileOpearator i in list)
                    {
                        if (i.Id == mId)
                        {
                            counter++;
                        }
                    }
                    if (counter >= 1)
                    {
                        p.mobileOpeartorId = mId;
                        p.personName = pName;
                        p.PersonId = pId;
                        list1.Add(p);
                        Console.WriteLine("Person added successfully");
                    }
                    else
                    {
                        throw new MobileOperatorNotFoundException("Operator is not a valid ");

                    }
                }
                catch (MobileOperatorNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
            } }
        public static void displayPerson()
        {
            Console.WriteLine("Enter the person id to search");
            int pid = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            foreach (Person p in list1)
            {
                if (p.PersonId == pid)
                {
                    foreach (MobileOpearator mo in list)
                    {
                        if (p.mobileOperatorId == mo.Id)
                        {
                            flag = 1;
                            Console.WriteLine("person name {0} person id {1},Mobile opeartor name { 2},mobile opeartor id { 3}", p.personName, p.PersonId, mo.Id);
                        }
                    }
                }
            }
            try
            {
                if (flag == 0)
                {
                    throw new PersonNotPresentException("No person is present to diaplay");
                }
            }
            catch (PersonNotFoundException p)
            {
                Console.WriteLine(p.Message);

            }
        }
        public static void displayMobileOperator()
        {
            try
            {
                if (list.Count == 0)
                {
                    throw new NullMobileOperatorException("No mobile operator to display");

                }
                else {
                    foreach (MobileOpearator mo in list)
                    {
                        Console.WriteLine("Operator id {0}||operator name{1}||operator rating{2}", mo.Id, mo.name, mo.rating);

                }
                }
            }
            catch (NullMobileoperatorException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void addMobileOperator()
        {
            MobileOpearator MO = new MobileOpearator();
            Console.WriteLine("enter mob operator id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter mob operator name");
            string operatorName = Console.ReadLine();
            int flag = 0;
            foreach (MobileOpearator Mo in list)
            {
                try
                {
                    if (MO.name.Equals(operatorName))
                    {
                        throw new DuplicateOperatorNameException("Operator name can not be dupliacte");

                    }
                } catch (DuplicateOperatorNameException e)
                {
                    flag = 1;
                    Console.WriteLine(e.Message);
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Enter the ratings");

                double ratings = Convert.ToDouble(Console.ReadLine());
                try
                {
                    if (ratings > 5)
                    {
                        throw new InvalidRatingException("Rating should be less than 5");
                        MO.Id = id;
                        MO.name = operatorName;
                        MO.rating = ratings;
                        list.Add(MO);
                        Console.WriteLine("Mobile operator succesfullly added");
                    }

                } catch (InvalidRatingException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static void addToFile()
        {
            string path = @"D:\visual\assignment";
            StreamWriter sw = new StreamWriter(path);
            foreach (Person i in list1)
            {
                Console.WriteLine(i.PersonId + "  " + i.personName + "  " + i.mobileOperatorId);
                sw.WriteLine(i.PersonId + "  " + i.personName + "  " + i.mobileOperatorId);

            }
            sw.Close();
        }


        public class InvalidRatingException : Exception
        {
            public InvalidRatingException(string message) : base(message)
            {

            }
        }
        public class DuplicateOpeartorNameException : Exception
        {
            public DuplicateOpeartorNameException(string message) : base(message)
            {

            }
        }
        public class NullMobileoperatorException : Exception
        {
            public NullMobileoperatorException(string message) : base(message)
            {

            }
        }
        public class MobileOperatorNotFoundException : Exception
        {
            public MobileOperatorNotFoundException(string message) : base(message)
            {

            }
        }
        public class DuplicatePersonIdException : Exception
        {
            public DuplicatePersonIdException(string message) : base(message)
            {

            }
        }
        public class PersonNotPresentException : Exception
        {
            public PersonNotPresentException(string message) : base(message)
            {

            }
        }

    }
}

























































































