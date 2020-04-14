using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingkeyword
{
    class Program
    {
        public static void Main(string szpath)
        {
            using (StreamReader StrFile = new StreamReader("D:\\powershell11"))
            {
           
                string szLine;
                while ((szLine = StrFile.ReadLine()) != null)
                {
                    Console.WriteLine(szLine);                   
                }

            } //file disposed here
        }
    }
}
