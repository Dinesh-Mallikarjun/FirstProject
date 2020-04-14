using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLayer
{
    public class DiseaseHasTwoSymptomsAlready:Exception
    {
        public DiseaseHasTwoSymptomsAlready(string message1):base(message1)
        {

        }
    }
    public class DiseaseAlreadyHasThisSymptom : Exception
    {
        public DiseaseAlreadyHasThisSymptom(string message2) : base(message2)
        {

        }
    }

}
