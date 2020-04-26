using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class MobileOperator : IComparable<MobileOperator>
    {
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public decimal OperatorRating { get; set; }
        

        public int CompareTo(MobileOperator other)
        {
            string operator1 = this.OperatorName.ToString();
            string operator2 = other.OperatorName.ToString();
            return operator1.CompareTo(operator2);
        }
    }
}
