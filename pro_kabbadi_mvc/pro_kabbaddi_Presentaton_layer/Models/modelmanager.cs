using EntityLayer;
using pro_kabbaddi_business_Layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace pro_kabbaddi_Presentaton_layer.Models
{
    public class modelmanager
    {
        static Business business = new Business();
        public List<TeamModel> DisplayTeams()
        {
            List<Teams> teams = business.DisplayTeams();
            List<TeamModel> teamModels = new List<TeamModel>();
            foreach (var team in teams)
            {
                TeamModel teamModel = new TeamModel();
                teamModel.TEAM_ID = team.TEAM_ID;
                teamModel.TEAM_NAME = team.TEAM_NAME;
                teamModel.TEAM_CITY = team.TEAM_CITY;

                teamModels.Add(teamModel);
            }
            return teamModels;
        }
        public void AddMatches(MatchModel matchModel)
        {
            Matches matches = new Matches();
            matches.MATCH_DATE = matchModel.MATCH_DATE;


            Teams team1 = new Teams();
            team1.TEAM_ID = matchModel.FIRST_TEAM_ID.TEAM_ID;
            matches.FIRST_TEAM_ID = team1;

            Teams team2 = new Teams();
            team2.TEAM_ID = matchModel.SECOND_TEAM_ID.TEAM_ID;
            matches.SECOND_TEAM_ID = team2;

            matches.FIRST_TEAM_SCORE = matchModel.FIRST_TEAM_SCORE;
            matches.SECOND_TEAM_SCORE = matchModel.SECOND_TEAM_SCORE;

            Business business = new Business();
            business.AddMatches(matches);
        }
        //public void exportDataToTextFile()
        //{
        //    //List<Teams> teams = business.exportDataToTextFile();
        //    List<TeamModel> teamModels = new List<TeamModel>();
        //    foreach (Teams teamentity in business.exportDataToTextFile())
        //    {
        //        StreamWriter.Write(teamentity.TEAM_ID + "\t\t");
        //        StreamWriter.Write(teamentity.TEAM_NAME + "\t\t");
        //        StreamWriter.Write(teamentity.TEAM_CITY + "\t\t\t" + "\n");
        //    }

        //}
        private static void exportDataToTextFile()
        {
            string filepath = @"D:\kabaddiMvc.txt";
            using (StreamWriter streamWriter = new StreamWriter(filepath))
            {
                foreach (Teams teamentity in business.DisplayTeams())
                {
                    streamWriter.Write(teamentity.TEAM_ID + "\t\t");
                    streamWriter.Write(teamentity.TEAM_NAME + "\t\t");
                    streamWriter.Write(teamentity.TEAM_CITY + "\t\t\t" + "\n");
                }                
            }
        }
    }
}