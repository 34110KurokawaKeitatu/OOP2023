﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            var count = text.Count(c => c == ' ');
            Console.WriteLine(count);
        }

        private static void Exercise3_2(string text) {
            var re = text.Replace("big","small");
            Console.WriteLine(re);
        }

        private static void Exercise3_3(string text) {
            var count = text.Split(' ').Count();
            Console.WriteLine("単語数：" + count);
        }

        private static void Exercise3_4(string text) {
            var re = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var s in re)
            {
                Console.WriteLine(s);
            }
            
        }

        private static void Exercise3_5(string text) {
            var split = text.Split(' ').ToArray();
            var builder = new StringBuilder(split[0]);
            foreach(var s in split.Skip(1))
            {
                builder.Append(' ');
                builder.Append(s);

            }
            var to = builder.ToString();
            Console.WriteLine(to);
        }
    }
}
