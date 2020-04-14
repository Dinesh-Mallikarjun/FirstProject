using EntityLayer;
using ExceptionLayer;
using Microsoft.Office.Interop.Excel;
using Pro_Kabbadi_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProKabbadii
{
   public class Presentation
    {       
            public static business business = new business();
            static List<Matchentity> matchentities = new List<Matchentity>();
            static void Main(string[] args)
            { 
            bool flag = true;
            try
            {
                do
                {
                    Console.WriteLine("Enter your choice");
                    Console.WriteLine("1.Add Match details");
                    Console.WriteLine("2.List all Matches Played by a given team");
                    Console.WriteLine("3.Export all data in teams table to text file ");
                    Console.WriteLine("4.Export all data in Matches table to Excel");
                    Console.WriteLine("5.Exit");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:                           
                            DisplayTeams();
                            AddMatchDetails();
                            break;
                        case 2:
                            DisplayTeams();
                            GetMatchDeatilsByTeam();                         
                            break;
                        case 3:
                            exportDataToTextFile();
                            break;
                        case 4:
                            exportToExcel();                          
                            break;
                        case 5:
                            flag = false;
                            Console.WriteLine("Thank you");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("You have entered wrong choice please ");
                            break;
                    }                                             
                } while (flag);
            }
            
            catch(InvalidData e)
            {
                Console.WriteLine(e.Message);
            }
            //catch()
            //Console.ReadKey();
        }

        public static void DisplayTeams()
        {
            Console.WriteLine("TEAMS DETAILS");
            Console.WriteLine("TEAM_ID\t\t\tTEAM_NAME\t\t\t\t\tTEAM_CITY");
            foreach (Teamentity teamentity in business.DisplayTeams())
            {
                Console.Write(teamentity.TEAM_ID + "\t\t\t");
                Console.Write(teamentity.TEAM_NAME + "\t\t\t\t\t");
                Console.WriteLine(teamentity.TEAM_CITY);
                Console.WriteLine();
            }
        }
        public static void AddMatchDetails()
        {
            try
            {
                Console.Write("enter no. of mathces you want to add : ");
                int n = Convert.ToInt32(Console.ReadLine());
               
                for (int i = 0; i < n; i++)
                {
                    Matchentity matchentity = new Matchentity();

                    Console.Write("enter the Match Date : ");
                    DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                    matchentity.MATCH_DATE = dateTime;

                    Console.Write("enter the First Team id: ");
                    int Team1 = Convert.ToInt32(Console.ReadLine());
                    matchentity.FIRST_TEAM_ID = new Teamentity();
                    matchentity.FIRST_TEAM_ID.TEAM_ID = Team1;


                    Console.Write("enter the Second Team id: ");
                    int Team2 = Convert.ToInt32(Console.ReadLine());
                    matchentity.SECOND_TEAM_ID = new Teamentity();
                    matchentity.SECOND_TEAM_ID.TEAM_ID = Team2;


                    Console.Write("enter the First Team score: ");
                    int Team1Score = Convert.ToInt32(Console.ReadLine());
                    matchentity.FIRST_TEAM_SCORE = Team1Score;

                    Console.Write("enter the Second Team score: ");
                    int Team2Score = Convert.ToInt32(Console.ReadLine());
                    matchentity.SECOND_TEAM_SCORE = Team2Score;

                    matchentities.Add(matchentity);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
                business.AddMatches(matchentities);

        }
        private static void exportDataToTextFile()
        {
            string filepath = @"D:\kabaddi.txt";
            using (StreamWriter streamWriter = new StreamWriter(filepath))
            {
                foreach(Teamentity teamentity in business.DisplayTeams())
                {
                    streamWriter.Write(teamentity.TEAM_ID + "\t\t");
                    streamWriter.Write(teamentity.TEAM_NAME + "\t\t");
                    streamWriter.Write(teamentity.TEAM_CITY + "\t\t\t" + "\n");
                }
                Console.WriteLine("data exported to text file successfully ");
            }
        }
        public static void exportToExcel()
        {
            List<Matchentity> matchentities = new List<Matchentity>();
            matchentities = business.GetMatchDetails();
            business.ExportToExcel(matchentities);
            Console.WriteLine("data exported to excel file successfully ");
            
        }
        public static void GetMatchDeatilsByTeam()
        {
            Teamentity teamentity  = new Teamentity();
            Console.WriteLine("Enter Team_Name");
            teamentity.TEAM_NAME = Console.ReadLine();
            List<Matchentity> matches = business.DisplayAllMatches(teamentity);          
            
            foreach (Matchentity match in matches)
            {
                if (match.FIRST_TEAM_ID.TEAM_NAME == teamentity.TEAM_NAME)
                {
                    Console.WriteLine($"{match.MATCH_DATE}\t\t\t\t{match.SECOND_TEAM_ID.TEAM_NAME}\t\t\t\t{match.FIRST_TEAM_SCORE}-{match.SECOND_TEAM_SCORE}");
                    Console.WriteLine();
                }
                else if (match.SECOND_TEAM_ID.TEAM_NAME == teamentity.TEAM_NAME)
                {
                    Console.WriteLine($"{match.MATCH_DATE}\t\t\t\t{match.FIRST_TEAM_ID.TEAM_NAME}\t\t\t\t{match.FIRST_TEAM_SCORE}-{match.SECOND_TEAM_SCORE}");
                    Console.WriteLine();
                }
            }
        }       
    }
}

