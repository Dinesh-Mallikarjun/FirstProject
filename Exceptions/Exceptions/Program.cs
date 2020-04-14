using System;
using System.Linq;

class User
{
    public int userId;
    public string dateOfBirth;
    public string userName;
    public char gender;
    public string guardianName;


    public User()
    {
        this.userId = 0;
        this.dateOfBirth = null;
        this.userName = null;
        this.gender = '\0';
        this.guardianName = null;
    }

    public User(int uid, string dob, string uname, char gen, string gname)
    {
        this.userId = uid;
        this.dateOfBirth = dob;
        this.userName = uname;
        this.gender = gen;
        this.guardianName = gname;
    }
}

class UserManager
{
    public static object Integer { get; private set; }

    public User createUser(User usr)
    {
        usr = new User();
        Console.WriteLine("Enter user id : ");
        usr.userId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter date of birth : ");
        usr.dateOfBirth = Console.ReadLine();
        Console.WriteLine("Enter user name :");
        usr.userName = Console.ReadLine();
        Console.WriteLine("Enter gender : ");
        usr.gender = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter guardian name : ");
        usr.guardianName = Console.ReadLine();
        String id = "";
        while (true)
        {
            // id = leer.next();
            try
            {
                int.Parse(id.Substring(0, 8));
            }
            catch (InvalidUserIdException e)
            {
                Console.WriteLine("Invalid Input");
                continue;
            }
            if (id.Length != 5)
            {
                continue;
            }
            if (Char.IsLetter(id.ElementAt(4))) break;
        }
        Console.ReadKey();

        return usr;
    }
    public void showUserDetails(User usr)
    {
        Console.WriteLine("-------------User Details-------------");
        Console.WriteLine("User id is : " + usr.userId);
        Console.WriteLine("Date of birth is : " + usr.dateOfBirth);
        Console.WriteLine("User name is : " + usr.userName);
        Console.WriteLine("Gender :" + usr.gender);
        Console.WriteLine("Guardian name is : " + usr.guardianName);
        Console.WriteLine("-------------Thank You-------------");
        Console.ReadKey();
    }
}
//    public static String readId()
//    {
//        String id = "";
//        while (true)
//        {
//           // id = leer.next();
//            try
//            {
//                int.Parse(id.Substring(0, 8));
//            }
//            catch (InvalidUserIdException e)
//            {
//                Console.WriteLine("Invalid Input");
//                continue;
//            }
//            if (id.Length != 5)
//            {
//                continue;
//            }
//            if (Char.IsLetter(id.ElementAt(4))) break;
//        }
//        return id;
//    }
//}
class MainClass
{
    public static void Main(string[] args)
    {
        
        User usr = new User();
        UserManager usr1 = new UserManager();
        User usr2 = usr1.createUser(usr);
        usr1.showUserDetails(usr2);

        Console.ReadKey();

    }
}