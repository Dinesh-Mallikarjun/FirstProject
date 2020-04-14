using System;

class Account
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
class AccountMgr
{
    public Account storeData(Account ob)
    {
        ob = new Account();
        Console.WriteLine("Enter account number : ");
        ob.accountNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter account Type : ");
        ob.accountType = Console.ReadLine();

        Console.WriteLine("Enter debit card number number : ");
        ob.debitCardNo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter pin : ");
        ob.pin = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter login id : ");
        ob.loginId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter password : ");
        ob.password = Console.ReadLine();

        Console.WriteLine("Enter balance : ");
        ob.balance = Convert.ToDouble(Console.ReadLine());
        Console.ReadKey();
        return ob;
    }
    public void showData(Account ob)
    {
        Console.WriteLine("Details of candidate ");
        Console.WriteLine("Account number: " + ob.accountNo);
        Console.WriteLine("Account type:" + ob.accountType);
        Console.WriteLine("Debit card no:" + ob.debitCardNo);
        Console.WriteLine("Pin:" + ob.pin);
        Console.WriteLine("login Id: " + ob.loginId);
        Console.WriteLine("Password: " + ob.password);
        Console.WriteLine("" + ob.balance);

    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        Account ob = new Account();
        AccountMgr obj1 = new AccountMgr();
        Account obj2 = obj1.storeData(ob);
        obj1.showData(obj2);
    }
}