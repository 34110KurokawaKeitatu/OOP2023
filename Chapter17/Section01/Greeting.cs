using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class GreetingMorning : GreetingBase{
        public override string GetMessage() {
            return "おはよう";
        }
    }
    class GreetingAfternoon : GreetingBase{
       public override string GetMessage() {
            return "こんにちわ";
       }
    }
    class GreetingEvening : GreetingBase{
        public override string GetMessage() {
            return "こんばんは";
        }
    }
}
