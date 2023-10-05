using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var texts = new[] {
               "Time is money.",
               "What time is it?",
               "It will take time.",
               "We reorganized the timetable.",
            };
            var regex = new Regex(@"\w[T|t]");
            foreach (var item in texts)
            {
                var matchs = Regex.Matches(item,@"\b(T|t)ime\b");
                    foreach (Match s in matchs)
                    {
                    Console.WriteLine("{0} {1}",item,s.Index);
                    }
            }



        }
    }
}
