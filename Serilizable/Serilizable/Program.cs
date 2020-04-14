using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serilizable
{
    [Serializable]
    class Student
        {
            int rollno;
            string name;
            public Student(int Rollno , string Name)
            {
                this.rollno = Rollno;
                this.name = Name;
            }
        }
    public class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("D:\\demo.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = new Student(1, "Akhil");
            formatter.Serialize(stream, s);
            Console.ReadKey();
            stream.Close();
        }
    }
}
