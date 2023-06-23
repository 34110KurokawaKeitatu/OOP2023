using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var flowerDict = new Dictionary<string, CityInfo>()
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
                var cityinfo = new CityInfo();
                if (flowerDict.ContainsKey(FlowerName))
                {
                    Console.WriteLine("重複しています");
                    Console.Write("上書きしますか　Y/N：");
                    var ans = Console.ReadLine();
                    if (ans == "Y")
                    {
                        Console.Write("所在地の入力:");
                        cityinfo.City = Console.ReadLine();
                        Console.Write("人口の入力:");
                        cityinfo.Population = int.Parse(Console.ReadLine());
                        flowerDict[FlowerName] = cityinfo;
                        Console.WriteLine("上書きしました");
                    }

                }
                else
                {
                    Console.Write("所在地の入力:");
                    cityinfo.City = Console.ReadLine();
                    Console.Write("人口の入力:");
                    cityinfo.Population = int.Parse(Console.ReadLine());
                    flowerDict[FlowerName] = cityinfo;
                }

                Console.Write("県名を入力:");
                FlowerName = Console.ReadLine();

            }
            Console.Write("1:一覧表示,2:県名指定 :");
            var num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                var kurokawwwwwa = flowerDict.OrderByDescending(s => s.Value.Population);
                foreach (var item in kurokawwwwwa)
                {
                    Console.WriteLine("{0}【{1}(人口：{2}人)】",item.Key,item.Value.City,item.Value.Population);
                }
            }
            else
            {
                Console.Write("松本を入力:");
                FlowerName = Console.ReadLine();
                Console.WriteLine(FlowerName + "({0}){1}", flowerDict[FlowerName].City,
                    flowerDict[FlowerName].Population);
            }
        }
        class CityInfo {
            public string City { get; set; }//都市
            public int Population { get; set; }//人口
        };
            

         //   Console.WriteLine("ひまわりの価格は{0}円です。",flowerDict["sunflower"]);
           // Console.WriteLine("チューリップの価格は{0}円です。",flowerDict["tulip"] );

    }
}

