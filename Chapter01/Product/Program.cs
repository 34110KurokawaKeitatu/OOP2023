using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    //商品クラス
    class Program {
        static void Main(string[] args) {

            //インスタンスの生成
            Product unnko = new Product(123,
                "かりんとう",180);

            Product moti = new Product(124,
                "大福餅", 1145);

            Console.WriteLine("かりんとうの税込み価格：" + 
                unnko.GetPriceIncludingTax());

            Console.WriteLine("大福の価格の税込み価格：" + 
                moti.GetPriceIncludingTax());
        }
    }
}
