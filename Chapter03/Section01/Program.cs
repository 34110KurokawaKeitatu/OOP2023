﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

       // public delegate bool Judgement(int value); //ゲリゲートの宣言

        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 7, 7, 5, 8, 1, 0, 5, 10, 4 };
            // Judgement judge = IsEven;
            int count = Count(numbers, delegate (int n) { return n % 2 == 0; });
            Console.WriteLine(count);
        }

        static public bool IsEven(int n) {
            return n % 2 == 1;
        }

        static public int Count (int[] numbers ,Predicate<int> judge) {
            int count = 0;
            foreach (var n in numbers)
            {
                if (judge(n) == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}