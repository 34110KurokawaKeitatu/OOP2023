﻿using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //InsertBooks();
            //using (var db = new BooksDbContext())
            //{
            //    var count = db.Books.Count();
            //    Console.WriteLine(count);
            //}
            Console.WriteLine("# 1.1");
           // Exercise1_1();

            Console.WriteLine();
            Console.WriteLine("# 1.2");
            Exercise1_2();

            Console.WriteLine();
            Console.WriteLine("# 1.3");
            Exercise1_3();

            Console.WriteLine();
            Console.WriteLine("# 1.4");
            Exercise1_4();

            Console.WriteLine();
            Console.WriteLine("# 1.5");
            Exercise1_5();
            Console.ReadLine();


        }

        private static void Exercise1_1() {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book
                {
                    Title = "ココロ",
                    PublishedYear = 1991,
                    Author = author1
                };
                db.Books.Add(book1);
                var book2 = new Book
                {
                    Title = "伊豆の踊り子",
                    PublishedYear = 2003,
                    Author = new Author
                    {

                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成",
                    }
                };
                db.Books.Add(book2);
                var book3 = new Book
                {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = new Author
                    {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛",
                    }
                };
                db.Books.Add(book3);
                var book4 = new Book
                {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = new Author
                    {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "宮沢賢治"
                    }
                };
                db.Books.Add(book4);
                db.SaveChanges();

            }
        }

        private static void Exercise1_2() {
            using (var db = new BooksDbContext()) {
                foreach (var book in db.Books.ToList())
                {
                    Console.WriteLine($"{book.Title} {book.PublishedYear}年 {book.Author.Name}");
                }
            }
        }

        private static void Exercise1_3() {
            using (var db = new BooksDbContext())
            {
                var select = db.Books.Max(s => s.Title.Length);
                var selevt = db.Books.Where(s => s.Title.Length == select);
                foreach (var item in selevt)
                {
                    Console.WriteLine(item.Title);
                }
            }
        }

        private static void Exercise1_4() {
            using (var db = new BooksDbContext())
            {
                var select = db.Books.OrderBy(s => s.PublishedYear.Value);
                var selevt = select.Take(3).ToList();
                foreach (var item in selevt)
                {
                    Console.WriteLine($"{item.Title} {item.Author.Name}");
                }
            }
        }

        private static void Exercise1_5() {
            using (var db = new BooksDbContext())
            {
                var select = db.Authors.OrderByDescending(s => s.Birthday);
                foreach (var item in select)
                {
                    Console.WriteLine($"{item.Name} {item.Birthday}");
                    foreach(var book in item.Books)
                    {
                        Console.WriteLine($"{book.Author.Name} {book.PublishedYear}");
                    }
                }
            }
        }

        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext())
            {
                var book1 = new Book
                {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);
                var book2 = new Book
                {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author
                    {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();　//データーベースを更新
                Console.WriteLine($"{book1.Id} {book2.Id} ");
            }


        }
        //List 13-7
        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext())
            {
                return db.Books
                    .Where(Book => Book.PublishedYear > 1900)
                    .Include(nameof(Author))
                    .ToList();
            }
        }
        //List 13-8
        static void DispaltAllBooks() {
            var books = GetBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} {book.PublishedYear}");
            }
            Console.ReadLine();
        }

        //List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子",

                };
                db.Authors.Add(author1);
                var author2 = new Author
                {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治",
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }

        }
    
        private static void AddBooks() {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var books1 = new Book
                {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1
                };
                db.Authors.Add(author1);
                var autor2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var Book2 = new Book
                {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = autor2
                };
                db.Books.Add(Book2);
                db.SaveChanges();
            }
        }
        // List 13-11
        private static void UpdateBook() {
            using (var db = new BooksDbContext())
            {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        // List 13-12
        private static void DeleteBook() {
            using (var db = new BooksDbContext())
            {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if (book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }
    }
}
