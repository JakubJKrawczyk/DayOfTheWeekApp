using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheWeekApp.core
{
    public class DayCalculator
    {
        public DayOfTheWeek CalculateDayOfTheWeek(DateTimeOffset date)
        {
            var day = date.Day;

            var month = date.Month;

            var year = date.Year;

            var ListOfParameters = new List<int>() { 0, 3, 2, 5, 0, 3, 5, 1,
                                4, 6, 2, 4 };


            
            year -= month < 3 ? 1 : 0 ;

            var CalculatedValue = (year + year / 4 - year / 100 + year / 400
                              + ListOfParameters[month - 1] + day) % 7;

            

            return (DayOfTheWeek)(CalculatedValue);
        }
       }
}
