using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {
            string[] moneyString = { "一万円札", "五千円札", "二千円札", "千円札",
                                        "五百円玉", "百円玉", "五十円玉", "十円玉", "五円玉", "一円玉" };
            int[] moneyInteger = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };

            //金額の入力
            Console.Write("合計金額：");
            int total = int.Parse(Console.ReadLine());

            //支払い金額入力
            Console.Write("支払い：");
            int pay = int.Parse(Console.ReadLine());

            //お釣りの計算
            int change = pay - total;
            Console.WriteLine("お釣り：{0}円", change);

            //金種枚数出力
            for (int i = 0; i < moneyString.Length; i++)
            {
                Console.WriteLine(moneyString[i] + "：{0}枚", change / moneyInteger[i]);
                change %= moneyInteger[i];
            }

        }
    }
}