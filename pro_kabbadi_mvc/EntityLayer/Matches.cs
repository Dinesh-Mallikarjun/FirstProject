using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Matches
    {
        public int MATCH_ID { get; set; }
        public DateTime MATCH_DATE { get; set; }
        public Teams FIRST_TEAM_ID { get; set; }
        public Teams SECOND_TEAM_ID { get; set; }
        public int FIRST_TEAM_SCORE { get; set; }
        public int SECOND_TEAM_SCORE { get; set; }
    }
}
