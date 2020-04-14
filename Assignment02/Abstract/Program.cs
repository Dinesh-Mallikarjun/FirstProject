using System;

public class Account
{
    public int accountNo;
    public string accountType;
    public int debitCardNo;
    public int pin;
    public int loginId;
    public string password;
    public double balance;

    public int AccNo
    {
        get { return accountNo; }
        set { accountNo = value; }
    }
    public string accType
    {
        get { return accountType; }
        set { accountType = value; }
    }
    public int debCardNo
    {
        get { return debitCardNo; }
        set { debitCardNo = value; }
    }
    public int pin1
    {
        get { return pin; }
        set { pin = value; }
    }
    public int logid
    {
        get { return loginId; }
        set { loginId = value; }
    }
    public string pass
    {
        get { return password; }
        set { password = value; }
    }
    public double bala
    {
        get { return balance; }
        set { balance = value; }
    }
}
public class Current : Account
{
    public string companyName;
    public string typeOfBusiness;
    public string website;
    public string contactName;

    public string Companyname
    {
        get { return companyName; }
        set { companyName = value; }
    }
    public string Typeofbusiness
    {
        get { return typeOfBusiness; }
        set { typeOfBusiness = value; }
    }
    public string Website
    {
        get { return website; }
        set { website = value; }
    }
    public string Contactname
    {
        get { return contactName; }
        set { contactName = value; }
    }

}
public class Savings_Corporate : Account
{
    public string companyName;

    public string Companynam
    {
        get { return companyName; }
        set { companyName = value; }
    }
}
public class AccountManager
{

    public Current createUser(Current cur)
    {
        cur = new Current();
        Console.WriteLine("Enter acccount number : ");
        cur.accountNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter account type: ");
        cur.accountType = Console.ReadLine();
        Console.WriteLine("Enter debit card number :");
        cur.debCardNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter pin : ");
        cur.pin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter logn id : ");
        cur.loginId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter password: ");
        cur.password = Console.ReadLine();
        Console.WriteLine("Enter balance : ");
        cur.balance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Company name : ");
        cur.companyName = Console.ReadLine();
        Console.WriteLine("Enter type of the business : ");
        cur.typeOfBusiness = Console.ReadLine();
        Console.WriteLine("Enter website : ");
        cur.website = Console.ReadLine();
        Console.WriteLine("Enter contact name : ");
        cur.contactName = Console.ReadLine();
        return cur;

    }
    public Savings_Corporate CreateUser2(Savings_Corporate scor)
    {
        scor = new Savings_Corporate();
        Console.WriteLine("Enter acccount number : ");
        scor.accountNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter account type: ");
        scor.accountType = Console.ReadLine();
        Console.WriteLine("Enter debit card number :");
        scor.debCardNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter pin : ");
        scor.pin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter logn id : ");
        scor.loginId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter password: ");
        scor.password = Console.ReadLine();
        Console.WriteLine("Enter balance : ");
        scor.balance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Company name : ");
        scor.companyName = Console.ReadLine();

        return scor;

    }
    public void DisplayAccount(Current cur)
    {
        Console.WriteLine("-------------Current account details-------------");
        Console.WriteLine("account number   : " + cur.accountNo);
        Console.WriteLine("account type is  : " + cur.accountType);
        Console.WriteLine("debit card number: " +cur.debCardNo);
        Console.WriteLine("pin :" + cur.pin);
        Console.WriteLine("login id : " + cur.loginId);
        Console.WriteLine("password : " + cur.password);
        Console.WriteLine("balance : " + cur.balance);
        Console.WriteLine("Comapny name is  : " + cur.companyName);
        Console.WriteLine("Type od business is : " + cur.typeOfBusiness);
        Console.WriteLine("website : " + cur.website);
        Console.WriteLine("contact name  : " + cur.contactName);

        Console.WriteLine("-------------Thank You-------------");
        Console.ReadKey();
    }
    public void DisplayAccount2(Savings_Corporate scor)
    {
        Console.WriteLine("-------------Savings account details-------------");
        Console.WriteLine("account number   : " + scor.accountNo);
        Console.WriteLine("account type is  : " + scor.accountType);
        Console.WriteLine("debit card number: " + scor.debCardNo);
        Console.WriteLine("pin :" + scor.pin);
        Console.WriteLine("login id : " + scor.loginId);
        Console.WriteLine("password : " + scor.password);
        Console.WriteLine("balance : " + scor.balance);
        Console.WriteLine("Comapny name is  : " + scor.companyName);

        Console.WriteLine("-------------Thank You-------------");
        Console.ReadKey();


    }
}
class MainClass
{
    public static void Main()
    {

        Current cur = new Current();
        AccountManager accm1 = new AccountManager();
        Current accm2 = accm1.createUser(cur);
        accm1.DisplayAccount(accm2);
        Console.ReadKey();



        Savings_Corporate scor = new Savings_Corporate();
        AccountManager scor1 = new AccountManager();
        Savings_Corporate scor2 = scor1.CreateUser2(scor);
        scor1.DisplayAccount2(scor2);
        Console.ReadKey();



    }
}



