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
            var info = Library.Books.First(s => s.Price == pricemax);
            Console.WriteLine(info);
        }

        private static void Exercise1_3() {
            var yearcount = Library.Books.GroupBy(s => s.PublishedYear);

            foreach (var item in yearcount)
            {
                Console.WriteLine("{0}年={1}冊",item.Key,item.Count());
            }
            
        }

        private static void Exercise1_4() {
            var books = Library.Books
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.PublishedYear)
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    Title = book.Title,
                    Category = category.Name,
                    PublishedYear = book.PublishedYear,
                    Price = book.Price
                }
                );
            foreach(var pricemax in books)
            {
                Console.WriteLine("{0}年　{1}円　{2}（{3}）",pricemax.PublishedYear,pricemax.Price,pricemax.Title,pricemax.Category);
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => category.Name)
                .Distinct();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }

        private static void Exercise1_6() {
            var groups = Library.Categories
                .GroupJoin(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new { Category = c.Name, Books = books }).OrderBy(x => x.Category);
            foreach (var item in groups)
            {
                Console.WriteLine("{0}",item.Category);
                foreach (var items in item.Books)
                {
                    Console.WriteLine($" {items.Title} ({items.PublishedYear}年)");
                }
            }
        }

        private static void Exercise1_7() {
            var books = Library.Books
                .Where(b => b.CategoryId ==1)
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    Title = book.Title,
                    Category = category.Name,
                    PublishedYear = book.PublishedYear,
                    Price = book.Price
                }
                );
            foreach (var item in books.GroupBy(s => s.PublishedYear).OrderBy(s => s.Key))
            {
                Console.WriteLine("#{0}",item.Key);
                foreach (var items in item)
                {
                    Console.WriteLine(items.Title)
;                }
            }
            
        }
        private static void Exercise1_8() {
            var groups = Library.Categories
                    .GroupJoin(Library.Books,
                    c => c.Id,
                    b => b.CategoryId,
                    (c, books) => new { Category = c.Name, Count = books.Count() });
            foreach (var item in groups)
            {
                if(item.Count >= 4)
                {
                    Console.WriteLine(item.Category);
                }
            }
        }
    }
}
