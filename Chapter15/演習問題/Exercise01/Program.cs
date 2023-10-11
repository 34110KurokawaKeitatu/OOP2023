using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var pricemax = Library.Books.Max(s => s.Price);
            Console.WriteLine(pricemax);
        }

        private static void Exercise1_3() {
            var yearcount = Library.Books.GroupBy(s => s.PublishedYear);

            foreach (var item in yearcount)
            {
                Console.WriteLine("{0}年={1}冊",item.Key,item.Count());
            }
            
        }

        private static void Exercise1_4() {
            var year = Library.Books.GroupBy(s => s.PublishedYear);
            foreach(var pricemax in year)
            {
                Console.WriteLine(pricemax);
            }
        }

        private static void Exercise1_5() {
            
        }

        private static void Exercise1_6() {
            
        }

        private static void Exercise1_7() {
            
        }

        private static void Exercise1_8() {
            
        }
    }
}
