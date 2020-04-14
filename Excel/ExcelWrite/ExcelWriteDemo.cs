using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelWrite
{
    class ExcelWriteDemo
    {
        static void Main(string[] args)
        {
            string fileName, Sampletext;
            Console.Write("Enter File Name :");
            fileName = Console.ReadLine();

            Console.Write("Enter text :");
            Sampletext = Console.ReadLine();

            Console.Write("Enter text 2:");
            string Sampletext2 = Console.ReadLine();

            


            Excel.Application xlSamp = new Microsoft.Office.Interop.Excel.Application();
            if (xlSamp == null)
            {
                Console.WriteLine("Excel is not Insatalled");
                Console.ReadKey();
                return;
            }

           
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

           
            xlWorkBook = xlSamp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = Sampletext;
            xlWorkSheet.Cells[2, 1] = Sampletext2 ;


            string location = @"D:\" + fileName + ".xls";
            xlWorkBook.SaveAs(location, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlSamp.Quit();

             
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSamp);
                xlSamp = null;
            }
            catch (Exception ex)
            {
                xlSamp = null;
                Console.Write("Error " + ex.ToString());
                Console.ReadKey();
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
