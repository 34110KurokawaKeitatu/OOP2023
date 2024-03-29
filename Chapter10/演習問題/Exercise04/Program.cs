﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");
            var newline = lines.Select(s => Regex.Replace(s, @"\b(V|v)ersion\s*=\s*""v4.0""",@"version=""5.0"""));



            File.WriteAllLines("sample.txt",newline);


            // これ以降は確認用
            var text = File.ReadAllText("sample.txt");
            Console.WriteLine(text);
        }
    }
}
