using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruyumBL
{
    public class DateUtility
    {
        public DateTime ConvertToDate(string inputDate)
        {
            return DateTime.Parse(inputDate);
        }
    }
}
