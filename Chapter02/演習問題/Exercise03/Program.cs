using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            var amountPerStore = sales.GetPerStoreSales();
            var PurductPerStore = sales.GetPerProductSales();

            Console.WriteLine("**売上集計**");
            Console.WriteLine("1:店舗別売上");
            Console.WriteLine("2:商品別カテゴリー別売上");
            Console.Write(">");
            var str = int.Parse(Console.ReadLine());
            if (str == 1) {
                foreach (var obj in amountPerStore)
                {
                    Console.WriteLine("{0}{1:#,0}", obj.Key, obj.Value);
                }
            }else if (str == 2)
            {
                foreach (var obj in PurductPerStore)
                {
                    Console.WriteLine("{0}{1:#,0}", obj.Key, obj.Value);
                }

            }
        }
    }
}
