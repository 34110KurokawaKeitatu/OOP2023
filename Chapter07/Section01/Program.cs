using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var flowerDict = new Dictionary<string, string>()
            {
                /*  ["sunflower"] = 400,
                  ["pansy"] = 300,
                  ["tulip"] = 350,
                  ["rose"] = 500,
                  ["dahlia"] = 450, */
            };

            //          flowerDict["morning glory"] = 250;
            Console.Write("県名を入力:");
            var FlowerName = Console.ReadLine();

            while (FlowerName != "999")
            {

                if (flowerDict.ContainsKey(FlowerName))
                {
                    Console.WriteLine("重複しています");
                    Console.Write("上書きしますか　Y/N：");
                    var ans = Console.ReadLine();
                    if (ans == "Y")
                    {
                        Console.Write("所在地の入力:");
                        var FlowerPraice = Console.ReadLine();
                        flowerDict[FlowerName] = FlowerPraice;
                    }

                }
                else
                {
                    Console.Write("所在地の入力:");
                    var FlowerPraice = Console.ReadLine();
                    flowerDict[FlowerName] = FlowerPraice;
                }
                Console.Write("県名を入力:");
                FlowerName = Console.ReadLine();

            }
            Console.Write("1:一覧表示,2:県名指定 :");
            var num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                foreach (var item in flowerDict)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.Write("松本を入力:");
                FlowerName = Console.ReadLine();
                Console.WriteLine(FlowerName + "({0})", flowerDict[FlowerName]);
            }
        }
        class CityInfo {
            string City { get; set; }
            int Population { get; set; }
        };
            

         //   Console.WriteLine("ひまわりの価格は{0}円です。",flowerDict["sunflower"]);
           // Console.WriteLine("チューリップの価格は{0}円です。",flowerDict["tulip"] );

        }
    }

