using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Console.WriteLine("**** 3.1 ****");
            Exercise2_1(names);
            Console.WriteLine("**** 3.2 ****");
            Exercise2_2(names);
            Console.WriteLine("**** 3.3 ****");
            Exercise2_3(names);
            Console.WriteLine("**** 3.4 ****");
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            do
            {
                Console.Write("都市名を入力/空白で終了:");
                var cantoly = Console.ReadLine();
                if (string.IsNullOrEmpty(cantoly))
                {
                    break;
                }
                else
                {
                    var num = names.FindIndex(n => n == cantoly);
                    Console.WriteLine(num);
                }
            } while (true);

        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(n => n.Contains("o"));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var list = names.Where(n => n.Contains("o")).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
        }

        private static void Exercise2_4(List<string> names) {
          
        }
    }
}
