using EntityLayer;
using pro_kabbaddi_dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_kabbaddi_business_Layer
{
    public class Business
    {
        DataAccess dataAccess = new DataAccess();

        public List<Teams> DisplayTeams()
        {
            return dataAccess.DisplayTeams();
        }
        public void AddMatches(Matches matches)
        {
            dataAccess.AddMatches(matches);
        }
        public void exportDataToTextFile()
        {
            dataAccess.exportDataToTextFile();
        }
    }
}
