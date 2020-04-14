using System;


namespace assignment01._2
{
    public class Current
    {
        public string companyName;
        public string typeOfBusiness;
        public string website;
        public string contactName;

        public string getCompanyname()
        {
            return companyName;
        }
        public string getTypeofbusiness()
        {
            return typeOfBusiness;
        }
        public string getWebsite()
        {
            return website;
        }
        public string getContactname()
        {
            return companyName;
        }

    }
    class Companyname
    {
        public static void Main(string[] args)
        {
            Current c1 = new Current();
            Console.WriteLine("Enter C1 Companyname : ");
            c1.companyName = Console.ReadLine();
            Console.WriteLine("Enter C1 typeOfBusiness : ");
            c1.typeOfBusiness = Console.ReadLine();
            Console.WriteLine("Enter C1 website : ");
            c1.website = Console.ReadLine();
            Console.WriteLine("Enter C1 Contactname : ");
            c1.companyName = Console.ReadLine();

            Current c2 = new Current();
            Console.WriteLine("Enter C2  Companyname : ");
            c2.companyName = Console.ReadLine();
            Console.WriteLine("Enter C2 typeOfBusiness : ");
            c2.typeOfBusiness = Console.ReadLine();
            Console.WriteLine("Enter C2 website : ");
            c2.website = Console.ReadLine();
            Console.WriteLine("Enter C2 Contactname : ");
            c2.companyName = Console.ReadLine();

            if ((c1.companyName).Equals(c2.companyName))
            {
                Console.WriteLine("Both comapany has same name : " + c1.getCompanyname());
            }
            else
            {
                Console.WriteLine("Both company has different names:");
                Console.WriteLine(c1.getCompanyname());
                Console.WriteLine(c2.getCompanyname());
            }
            Console.ReadKey();
        }
    }
}

