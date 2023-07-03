using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Now;

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek)))
            {

                var s = NextDay(dateTime,(DayOfWeek)dayofweek);
                Console.WriteLine("{1:yy/MM/dd}の次の週の曜日は{2}{0:yy/MM/dd(ddd)}",s,dateTime,dayofweek);

            }
           
        }
        public static DateTime NextDay(DateTime date , DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days >= -1)
            {
                days += 7;
               
            }
            return date.AddDays(days);
        }
    }
}
