using System;

class ContactInfo
{
    public string address;
    public string city;
    public string state;
    public string country;
    public string mobileNo;
    public string email;

    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string State
    {
        get { return state; }
        set { state = value; }
    }
    public string Country
    {
        get { return country; }
        set { country = value; }
    }
    public string MobileNo
    {
        get { return mobileNo; }
        set { mobileNo = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
}
class ContactInfoMgr
{
    public ContactInfo storeData(ContactInfo ob)
    {
        ob = new ContactInfo();

        Console.WriteLine("Enter address : ");
        ob.address = Console.ReadLine();

        Console.WriteLine("Enter city : ");
        ob.city = Console.ReadLine();

        Console.WriteLine("Enter state : ");
        ob.state = Console.ReadLine();

        Console.WriteLine("Enter country: ");
        ob.country = Console.ReadLine();

        Console.WriteLine("Enter mobile number : ");
        ob.mobileNo = Console.ReadLine();

        Console.WriteLine("Enter email_id : ");
        ob.email = Console.ReadLine();

        return ob;
    }
    public void showData(ContactInfo ob)
    {
        Console.WriteLine("Details of candidate ");
        Console.WriteLine("Address : " + ob.address);
        Console.WriteLine("City :" + ob.city);
        Console.WriteLine("State :" + ob.state);
        Console.WriteLine("Country :" + ob.country);
        Console.WriteLine("Mobile no. : " + ob.mobileNo);
        Console.WriteLine("Email : " + ob.email);
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        ContactInfo ob = new ContactInfo();
        ContactInfoMgr obj1 = new ContactInfoMgr();
        ContactInfo obj2 = obj1.storeData(ob);
        obj1.showData(obj2);
        Console.ReadKey();
    }
}