using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {

    public class SalesCounter {

        private List<Sale> _sales;

        //コンストラクター
        public SalesCounter(String filePath) {
            _sales = ReadSales(filePath);
        }

        //  店舗別売上を求める
        public Dictionary<String, int> GetPerStoreSales(){
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] +=  sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;


        }
        //売上データを読み込み、Saleオブジェクトのリストを返す
       public static List<Sale> ReadSales(String filePath) {
            List<Sale> sales = new List<Sale>();//売り上げデーターを格納する
            string[] lines = File.ReadAllLines(filePath);//ファイルからすべてのデータを読み込む

            foreach (string line in lines)//すべての行から一行づつ取り出す
            {
                String[] items = line.Split(',');//区切りで項目別に分ける
                Sale sale = new Sale//saleインスタンスを生成
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);//saleインスタンスをコレクションに追加
            }

            return sales;
        }
    }
}
