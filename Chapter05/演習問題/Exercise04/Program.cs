using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {

            Stopwatch sw = new Stopwatch();

            sw.Start();

          //  var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886"; 

          string[] lines = {
            "Novelist=谷崎潤一郎;BestWork=春琴妙;Born=1886",
            "Novelist= 夏目漱石;BestWork=坊ちゃん:Born=1867",
            "Novelist=太宰治;BestWork=人間失格:Born=1909",
            "Novelist=宮崎賢治;BestWork=銀河鉄道の夜;Born=1896"
            };
            for (int i = 0; i < lines.Length; i++)
            {
                var repl = lines[i].Replace("Novelist=", "作者：").Replace("BestWork=", "作品：").Replace("Born=", "誕生日：");
                var prof = repl.Split(';').ToArray();

                foreach (var item in prof)
                {

                    Console.WriteLine(item);

                }
            }
            Console.WriteLine("実行時間 = {0}", sw.Elapsed.ToString(@"ss\.ffff")); ;
        }
    }
}
