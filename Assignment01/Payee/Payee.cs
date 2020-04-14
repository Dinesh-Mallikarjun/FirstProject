using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payee
{
    class Payee
    {
        public int payeeId;
        public int accNo;
        public string accName;
        public string bank;

        public int Payid
        {
            get { return payeeId; }
            set { payeeId = value; }
        }

        public int Accnumber
        {
            get { return accNo; }
            set { accNo = value; }
        }
        public string Accname
        {
            get { return accName; }
            set { accName = value; }
        }
        public string Bank
        {
            get { return bank; }
            set { bank = value; }
        }

    }
    class PayeeMgr
    {
        public Payee storeData(Payee ob)
        {
            ob = new Payee();

            Console.WriteLine("Enter payee id : ");
            ob.payeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter account number : ");
            ob.accNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter account name: ");
            ob.accName = Console.ReadLine();

            Console.WriteLine("Enter bank: ");
            ob.bank = Console.ReadLine();
            Console.ReadKey();
            return ob;
        }
        public void showData(Payee ob)
        {
            Console.WriteLine("-----Details of candidate------");
            Console.WriteLine("Payee id : " + ob.payeeId);
            Console.WriteLine("Account number : " + ob.accNo);
            Console.WriteLine("Account name : " + ob.accName);
            Console.WriteLine("bank : " + ob.bank);
            Console.ReadKey();
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Payee ob = new Payee();
            PayeeMgr obj1 = new PayeeMgr();
            Payee obj2 = obj1.storeData(ob);
            obj1.showData(obj2);
        }
    }
}