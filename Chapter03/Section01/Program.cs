﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Count(5));
        }
        static public int Count (int num) {
            var numbers = new[] { 5, 3, 9, 7, 7, 5, 8, 1, 0, 5, 10, 4 };
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (num == numbers[i])
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}
