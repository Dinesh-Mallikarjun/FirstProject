using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Matchentity : IComparable<Matchentity>
    {
        public int MATCH_ID { get; set; }
        public DateTime MATCH_DATE { get; set; }
        public Teamentity FIRST_TEAM_ID { get; set; }
        public Teamentity SECOND_TEAM_ID { get; set; }
        public int FIRST_TEAM_SCORE { get; set; }
        public int SECOND_TEAM_SCORE { get; set; }

        //public int CompareTo(Matchentity other)
        //{
        //    throw new NotImplementedException();
        //}

        public int CompareTo(Matchentity x)
        {
            string date1 = this.MATCH_DATE.ToString();
            string date2 = x.MATCH_DATE.ToString();
            return date1.CompareTo(date2);
        }
    }
}
