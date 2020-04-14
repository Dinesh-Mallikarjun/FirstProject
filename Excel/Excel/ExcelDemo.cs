﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;


namespace Excel
{
    public class ExcelDemo
    {  
            static void Main(string[] args)
            {
                Application excelApp = new Application();
                if (excelApp == null)
                {
                    Console.WriteLine("Excel is not installed!!");
                    return;
                }
                Workbook excelBook = excelApp.Workbooks.Open(@"D:\\read.xlsx");
                _Worksheet excelSheet = excelBook.Sheets[1];
                Range excelRange = excelSheet.UsedRange;

                int rows = excelRange.Rows.Count;
                int cols = excelRange.Columns.Count;

                for (int i = 1; i <= rows; i++)
                {
                    Console.Write("\r\n");
                    for (int j = 1; j <= cols; j++)
                    {

                        if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                            Console.Write(excelRange.Cells[i, j].Value2.ToString() + "\t");
                    }
                }
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                Console.ReadLine();
            }
        }
    }

