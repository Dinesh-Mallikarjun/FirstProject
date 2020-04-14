using EntityLayer;
using Pro_Kabbadi_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Kabbadi_BusinessLayer
{
    public class business
    {
        DataAccess dataAccess = new DataAccess();

        public List<Teamentity> DisplayTeams()
        {
            DataAccess dataAccess = new DataAccess();
            return dataAccess.DisplayTeams();
        }
        public bool AddMatches(List<Matchentity> matchentities)
        {
            try
            {
              dataAccess.AddMatches(matchentities);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return dataAccess.AddMatches(matchentities);
        }
        public List<Matchentity> GetMatchDetails()
        {
            return dataAccess.GetMatchDetails();
        }
        public void ExportToExcel(List<Matchentity> matchentities)
        {
            dataAccess.ExportToExcel(matchentities);
        }
             
        public List<Matchentity> DisplayAllMatches(Teamentity teamentity)
        {
            List<Matchentity> matches = dataAccess.DisplayAllMatches(teamentity);
            SortingGoals sortingGoals = new SortingGoals();
            matches.Sort(sortingGoals.Compare);
            List<Teamentity> TotalTeams = dataAccess.DisplayTeams();
            foreach (Matchentity match in matches)
            {
                
                foreach (Teamentity team in TotalTeams)
                {
                    if (team.TEAM_ID == match.SECOND_TEAM_ID.TEAM_ID)
                    {
                        match.SECOND_TEAM_ID.TEAM_NAME = team.TEAM_NAME;
                        break;
                    }
                }
               
                foreach (Teamentity team in TotalTeams)
                {
                    if (team.TEAM_ID == match.FIRST_TEAM_ID.TEAM_ID)
                    {
                        match.FIRST_TEAM_ID.TEAM_NAME = team.TEAM_NAME;
                        break;
                    }
                }
            }            
            return matches;
        }
        public class SortingGoals : IComparer<Matchentity>
        {
            
            public int Compare(Matchentity x, Matchentity y)
            {
                if ((x.FIRST_TEAM_SCORE - x.SECOND_TEAM_SCORE) < (y.FIRST_TEAM_SCORE - y.SECOND_TEAM_SCORE))
                {
                    return 1;
                }
                else if ((x.FIRST_TEAM_SCORE - y.FIRST_TEAM_SCORE) > (x.SECOND_TEAM_SCORE - y.SECOND_TEAM_SCORE))
                {
                    return -1;
                }
                else
                {
                    Matchentity matchentity = new Matchentity();
                    int Result = matchentity.CompareTo(x);
                    if (Result == 1)
                    {
                        return -1;
                    }
                    else if (Result == -1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }

                }
            }
        }
    }
}
