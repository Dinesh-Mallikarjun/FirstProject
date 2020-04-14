using EntityLayer;
using ExceptionLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Kabbadi_DataAccessLayer
{
    public class DataAccess
    {
        SqlConnection sqlConnection = new SqlConnection("data source=.;database='ProKabbadi_MATCH_DB';integrated security=SSPI");
        //private SqlConnection sqlConnection;
        //private void sqlconnection()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["connection"].ToString();
        //    sqlConnection = new SqlConnection(constr);
        //}
        public List<Teamentity> DisplayTeams()
        {
            List<Teamentity> TeamsList = new List<Teamentity>();
            sqlConnection.Open();
            SqlCommand sqlcmd = new SqlCommand("select * from TEAMS", sqlConnection);
            SqlDataReader sdr = sqlcmd.ExecuteReader();
            while (sdr.Read())
            {
                Teamentity teamentity = new Teamentity();
                teamentity.TEAM_ID = (int)sdr["TEAM_ID"];
                teamentity.TEAM_NAME = (string)sdr["TEAM_NAME"];
                teamentity.TEAM_CITY = (string)sdr["TEAM_CITY"];

                TeamsList.Add(teamentity);
            }
            sqlConnection.Close();

            return TeamsList;
        }


        public bool AddMatches(List<Matchentity> matchentities)
        {
            try
            {
                int rows = 0;
                sqlConnection.Open();
                for (int i = 0; i < matchentities.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("insertMatchdetail", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("MATCH_DATE", matchentities[i].MATCH_DATE);
                    cmd.Parameters.AddWithValue("FIRST_TEAM_ID", matchentities[i].FIRST_TEAM_ID.TEAM_ID);
                    cmd.Parameters.AddWithValue("SECOND_TEAM_ID", matchentities[i].SECOND_TEAM_ID.TEAM_ID);
                    cmd.Parameters.AddWithValue("FIRST_TEAM_SCORE", matchentities[i].FIRST_TEAM_SCORE);
                    cmd.Parameters.AddWithValue("SECOND_TEAM_SCORE", matchentities[i].SECOND_TEAM_SCORE);

                    rows = rows + cmd.ExecuteNonQuery();
                }
                if (rows > 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                throw new InvalidData("You have entered invalid data", e);
            }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }

        //getting match details
        public List<Matchentity> GetMatchDetails()
        {
            List<Matchentity> matchentities = new List<Matchentity>();
            SqlCommand sqlCommand = new SqlCommand("select * from MATCHESS", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {

                Matchentity matchentity = new Matchentity();

                Teamentity teamentity = new Teamentity();

                matchentity.MATCH_ID = sqlDataReader.GetInt32(0);
                matchentity.MATCH_DATE = sqlDataReader.GetDateTime(1);

                matchentity.FIRST_TEAM_ID = new Teamentity();
                teamentity.TEAM_ID = sqlDataReader.GetInt32(2);
                matchentity.FIRST_TEAM_ID.TEAM_ID = teamentity.TEAM_ID;

                matchentity.SECOND_TEAM_ID = new Teamentity();
                matchentity.SECOND_TEAM_ID.TEAM_ID = sqlDataReader.GetInt32(3);

                matchentity.FIRST_TEAM_SCORE = sqlDataReader.GetInt32(4);
                matchentity.SECOND_TEAM_SCORE = sqlDataReader.GetInt32(5);

                matchentities.Add(matchentity);
            }
            sqlConnection.Close();
            return matchentities;
        }
        public List<Matchentity> DisplayAllMatches(Teamentity teamentity)
        {
            try
            {
                List<Teamentity> teamentities = new List<Teamentity>();
                List<Matchentity> TotalMatches = new List<Matchentity>();
                List<Matchentity> matches = GetMatchDetails();
                //SqlConnection connections = new SqlConnection();
                using (SqlCommand command = new SqlCommand($"Select * from TEAMS where TEAM_NAME='{teamentity.TEAM_NAME}'", sqlConnection))
                {
                    sqlConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        teamentity.TEAM_ID = (int)reader.GetSqlInt32(0);
                        teamentity.TEAM_NAME = (string)reader.GetSqlString(1);
                        teamentity.TEAM_CITY = (string)reader.GetSqlString(2);

                    }
                    sqlConnection.Close();
                }
                foreach (Matchentity matchentity in matches)
                {
                    if (matchentity.FIRST_TEAM_ID.TEAM_ID == teamentity.TEAM_ID)
                    {
                        matchentity.FIRST_TEAM_ID.TEAM_ID = teamentity.TEAM_ID;

                        TotalMatches.Add(matchentity);

                    }
                    else if (matchentity.SECOND_TEAM_ID.TEAM_ID == teamentity.TEAM_ID)
                    {
                        matchentity.SECOND_TEAM_ID.TEAM_ID = teamentity.TEAM_ID;

                        TotalMatches.Add(matchentity);

                    }
                }
                return TotalMatches;
            }
            catch (Exception e)
            {
                throw new InvalidTeamName("You have entered invalid team name", e);
            }

        }
    
                             


        // exporting to excel 
        public void ExportToExcel(List<Matchentity> matchentities)
        {
           // SqlConnection sqlConnection = new SqlConnection("data source=.;database='ProKabbadi_MATCH_DB';integrated security=SSPI");

            OleDbConnection oleDbConnection;
            OleDbCommand oleDbCommand = new OleDbCommand();
            string result = null;
            foreach (Matchentity matchentity in matchentities)
            {
                // oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = D:\\demodemo.xlsx;Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
                oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\demodemo.xlsx;Extended Properties=Excel 12.0;");

                oleDbConnection.Open();
                oleDbCommand.Connection = oleDbConnection;
                result = "Insert into [Sheet1$]([MATCH_ID],[MATCH_DATE],[FIRST_TEAM_ID],[SECOND_TEAM_ID],[FIRST_TEAM_SCORE],[SECOND_TEAM_SCORE]) values (" + matchentity.MATCH_ID + ",'" + matchentity.MATCH_DATE + "'," + matchentity.FIRST_TEAM_ID.TEAM_ID + "," + matchentity.SECOND_TEAM_ID.TEAM_ID + "," + matchentity.FIRST_TEAM_SCORE + "," + matchentity.SECOND_TEAM_SCORE + ")";
                oleDbCommand.CommandText = result;
                oleDbCommand.ExecuteNonQuery();
                oleDbConnection.Close();

            }

        }

    }
}

               


  

