using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            Console.WriteLine("{0}/{1}/{2} {3}:{4}"
                , dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute);

        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            var str = String.Format("{0}年{1}月{2}日{3}時{4}分"
               , dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute);
            Console.WriteLine(str);
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str1 = dateTime.ToString("ggyy年M月d日", culture);
            Console.WriteLine(str1);

        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
            }
        }
    }
}
