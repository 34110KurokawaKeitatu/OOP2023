using System;
using EXercise01;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    public class Program {

        static void Main(String[] args) {
            var ym = new YearMonth(2023, 5);
            var c21 = ym.Is21Century;
            var ymNextMonth = ym.AddOneMonth();

            Console.WriteLine(ym);
            Console.WriteLine(ymNextMonth);
        }

        
    }
}
