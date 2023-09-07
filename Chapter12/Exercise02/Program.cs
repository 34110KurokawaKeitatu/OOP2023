using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var novelisst = Exercise2_1("sample.xml");
            Console.WriteLine("{0} {1}", novelisst.Name, novelisst.Birth);
        }


        private static object Exercise2_1(string v) {
            using (var reader = XmlReader.Create(v))
            {
                var serializer = new XmlSerializer(typeof(Novelist));
                var novelist = (Novelist)serializer.Deserialize(reader);
                return novelist;
            }
        }
        private static void Exercise2_2(Novelist novelist,string v) {
            using (var stream = new FileStream(v, FileMode.Create, FileAccess.Write))
            {
                var serializer = new DataContractJsonSerializer(novelist.GetType(),
                                     new DataContractJsonSerializerSettings
                                     {
                                         DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
                                     });
                serializer.WriteObject(stream, novelist);
            }
    }
}
