using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pro_kabbaddi_Presentaton_layer.Models
{
    public class MatchModel
    {
        public int MATCH_ID { get; set; }
        public DateTime MATCH_DATE { get; set; }
        public TeamModel FIRST_TEAM_ID { get; set; }
        public TeamModel SECOND_TEAM_ID { get; set; }
        public int FIRST_TEAM_SCORE { get; set; }
        public int SECOND_TEAM_SCORE { get; set; }
    }
}