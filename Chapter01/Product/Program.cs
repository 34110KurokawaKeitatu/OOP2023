using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    //商品クラス
    class Program {
        static void Main(string[] args) {

            #region　P26のサンプルプログラム
#if false
            //インスタンスの生成
            Product unnko = new Product(123,
                "かりんとう",180);

            Product moti = new Product(124,
                "大福餅", 1145);

            Console.WriteLine("かりんとうの税込み価格：" + 
                unnko.GetPriceIncludingTax());

            Console.WriteLine("大福の価格の税込み価格：" + 
                moti.GetPriceIncludingTax());
#endif
            #endregion

            #region
            DateTime date = DateTime.Today;
            string re = date.ToString("yyyy年MM月dd日");
            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            DateTime daysbefor10 = date.AddDays(-10);




            Console.WriteLine(date.ToString("yyyy年MM月dd日"));

            Console.WriteLine("今日の10日後は" +daysAfter10.ToString("yyyy年MM月dd日"));

            Console.WriteLine("今日の10日前は" + daysbefor10.ToString("yyyy年MM月dd日") );
            #endregion

            DateTime BD = new DateTime(2004,02,03);

            DateTime total = date.Subtract(BD).TotalDays;


        }
    }
}
