using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var greetings = new List<GreetingBase>() { new GreetingMorning(),
                                                       new GreetingAfternoon(),
                                                       new GreetingEvening(),};
            foreach (var item in greetings)
            {
                string msg = item.GetMessage();
                Console.WriteLine(msg);
            }
        }
    }
}
