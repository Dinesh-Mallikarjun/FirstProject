using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
       using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerAndDes
{

    
    class Program
    {
        [Serializable]
        class Tutorial
        {
            public int ID;
            public String Name;
            static void Main(string[] args)
            {
                Tutorial obj = new Tutorial();
                obj.ID = 1;
                obj.Name = ".Net";

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"D:\ExampleNew.txt", FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, obj);
                stream.Close();

                stream = new FileStream(@"D:\ExampleNew.txt", FileMode.Open, FileAccess.Read);
                Tutorial objnew = (Tutorial)formatter.Deserialize(stream);

                Console.WriteLine(objnew.ID);
                Console.WriteLine(objnew.Name);

                Console.ReadKey();
            }
        }
    }
}

