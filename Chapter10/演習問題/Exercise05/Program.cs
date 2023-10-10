using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise05 {
    class Program {
        static void Main(string[] args) {
            TagLower("sample.html");
            var text = File.ReadAllText("sample.html");
            Console.WriteLine(text);
        }

        private static void TagLower(string file) {
            var lines = File.ReadLines(file);
            var sb = new StringBuilder();
            foreach(var line in lines)
            {
                var newline = Regex.Replace(line,@"<(/?)([A-Z][A-Z0-9]*)(.*?)>",m => {
                    return string.Format("<{0}{1}{2}>", m.Groups[1].Value, m.Groups[2].Value.ToLower(), m.Groups[3].Value);
                }
                );
                sb.Append(newline);
            }

            //ファイル出力
            File.WriteAllText(file, sb.ToString());
        }
    }
}
