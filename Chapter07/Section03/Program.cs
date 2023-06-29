using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {
            
          var sbbrs = new Abbreviations();

            //Addメソッドの呼び出し例
            sbbrs.Add("ICO", "国際オリンピック");
            sbbrs.Add("NPT","核兵器不拡散条約");

            //インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach(var name in names)
            {
                var fullname = sbbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}は見つかりません", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();//改行

            //ToAddreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = sbbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine("{0}は見つかりません", japanese);
            else
                Console.WriteLine("{0}={1}", japanese, abbreviation);

            //fillAllメソッドの利用例
            foreach (var item in sbbrs.FindAll("国際"))
            {
                
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }
    }
}
