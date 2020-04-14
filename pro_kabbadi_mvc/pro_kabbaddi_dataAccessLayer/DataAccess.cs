using EntityLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_kabbaddi_dataAccessLayer
{
    public class DataAccess
    {
        //private SqlConnection sqlConnection;
        //private void connection()
        //{
            
        //    string constr = ConfigurationManager.ConnectionStrings["connection"].ToString();
        //    sqlConnection = new SqlConnection(constr);
        //}
        static SqlConnection sqlConnection = new SqlConnection("data source=.;database='ProKabbadi_MATCH_DB';integrated security=true");

        public  List<Teams> DisplayTeams()
        {
            //connection();
            List<Teams> TeamsList = new List<Teams>();
            SqlCommand sqlcmd = new SqlCommand("sp_DisplayTeams", sqlConnection);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlcmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Teams team = new Teams();
                team.TEAM_ID = (int)sqlDataReader["TEAM_ID"];
                team.TEAM_NAME = (string)sqlDataReader["TEAM_NAME"];
                team.TEAM_CITY = (string)sqlDataReader["TEAM_CITY"];

                TeamsList.Add(team);
            }
            sqlConnection.Close();

            return TeamsList;
        }

        public  void AddMatches (Matches matches)
        {
           
                
                    sqlConnection.Open();               
                    SqlCommand cmd = new SqlCommand("insertMatchdetail", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MATCH_DATE", matches.MATCH_DATE));
                    cmd.Parameters.Add(new SqlParameter("@FIRST_TEAM_ID", matches.FIRST_TEAM_ID.TEAM_ID));
                    cmd.Parameters.Add(new SqlParameter("@SECOND_TEAM_ID", matches.SECOND_TEAM_ID.TEAM_ID));
                    cmd.Parameters.Add(new SqlParameter("@FIRST_TEAM_SCORE", matches.FIRST_TEAM_SCORE));
                    cmd.Parameters.Add(new SqlParameter("@SECOND_TEAM_SCORE", matches.SECOND_TEAM_SCORE));
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();             
        }
        public  void exportDataToTextFile()
        {
            DataAccess dataAccess = new DataAccess();
           // List<Teams> teams = dataAccess.DisplayTeams();
            string filepath = @"D:\kabaddiMvc.txt";
            using (StreamWriter streamWriter = new StreamWriter(filepath))
            {
                foreach (Teams teamentity in dataAccess.DisplayTeams())
                {
                    streamWriter.Write(teamentity.TEAM_ID + "\t\t");
                    streamWriter.Write(teamentity.TEAM_NAME + "\t\t");
                    streamWriter.Write(teamentity.TEAM_CITY + "\t\t\t" + "\n");
                }
                Console.WriteLine("data exported to text file successfully ");
            }
        }
    }
}
