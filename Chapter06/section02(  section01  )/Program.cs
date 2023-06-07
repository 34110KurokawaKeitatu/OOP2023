using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section01{
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 1, 0, 4 };

            Console.WriteLine(numbers.Average());

            var books = Books.GetBooks();

            //500円以上の本のタイトルをすべて出力

            // Console.WriteLine(books.Average(s => s.Price));

            //  Console.WriteLine(books.Max(s => s.Price));

            var Boossoso = books.Where(s => s.Title.Contains("物語")).OrderByDescending(s => s.Price);

            Console.WriteLine(Boossoso.Average(s => s.Pages));

            var boo = books.OrderByDescending(s => s.Title.Length);

            foreach(var c in boo)
            {
                Console.WriteLine(c.Title);
            }

            foreach (var item in Boossoso)
            {
                Console.WriteLine("{0}:{1}円",item.Title ,item.Price , item.Title);
              
            }

        }
    }
}
