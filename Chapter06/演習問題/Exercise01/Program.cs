using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);


        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            var last2 = numbers.Skip(numbers.Length - 2);
            foreach (var item in last2)
            {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            var select = numbers.Select(s => s.ToString());
            foreach (var item in select)
            {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            var oder3 = numbers.OrderBy(s=> s);
            foreach (var item in oder3.Skip(0).Take(3))
            {
                Console.WriteLine(item);
            }
            
        }

        private static void Exercise1_5(int[] numbers) {
            throw new NotImplementedException();
        }
    }
}
