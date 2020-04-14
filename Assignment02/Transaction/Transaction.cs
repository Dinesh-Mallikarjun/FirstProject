using System;
class Transaction
{
    public int transactionId;
    public double amount;
    public string transDate;

    public Transaction()
    {
        this.transactionId = 0;
        this.amount = 0;
        this.transDate = null;
    }
    public Transaction(int transid, double amt, string tDate)
    {
        this.transactionId = transid;
        this.amount = amt;
        this.transDate = tDate;
    }

}
class TransactionManager
{
    public Transaction creatTransaction(Transaction trans)
    {
        trans = new Transaction();

        Console.WriteLine("Enter Transaction id :");
        trans.transactionId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter amount :");
        trans.amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter transaction date :");
        trans.transDate = Console.ReadLine();

        return trans;

    }
    public void showTransactionDetails(Transaction trans)
    {
        Console.WriteLine("\n");
        Console.WriteLine("---------Transaction Details--------");
        Console.WriteLine(" trans id is :" + trans.transactionId);
        Console.WriteLine("amount  is :" + trans.amount);
        Console.WriteLine("transaction date  is :" + trans.transDate);
        Console.ReadKey();

    }

}
class MainClass
{
    public static void Main(string[] args)
    {   
        Transaction trans = new Transaction();
        TransactionManager trans1 = new TransactionManager();
        Transaction trans2 = trans1.creatTransaction(trans);
        trans1.showTransactionDetails(trans2);
    }
}