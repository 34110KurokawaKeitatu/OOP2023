using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises02 {
    class Program {
        static void Main(string[] args) {

            var addrs = new Abbreviations();

            addrs.Add("ICO","国際オリンピック");
            addrs.Add("NPI","核拡散防止条約");


            Console.WriteLine(addrs.Count);
            Console.WriteLine();


            if (addrs.Remove("NPI"))
                Console.WriteLine(addrs.Count);
            if (!addrs.Remove("NPT"))
                Console.WriteLine("削除できません");
            Console.WriteLine();

            var a = addrs.Where(add => add.Key.Length == 3);

            foreach (var item in a)
            {
                Console.WriteLine("{0}={1}",item.Key,item.Value);
            }
        }
    }
}
