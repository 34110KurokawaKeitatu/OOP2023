using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            var emp = new Employee
            {
                Id = 00011,
                Name = "平澤彰久",
                HireDate = DateTime.Now,
            };
            using (var write = XmlWriter.Create(v))
            {
                var seriarize = new XmlSerializer(emp.GetType());
                seriarize.Serialize(write, emp);
            }
            using (var reader = XmlReader.Create(v))
            {
                var serializer = new XmlSerializer(typeof(Employee));
                var employee = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employee);
            }
        }

        private static void Exercise1_2(string v) {
            var emp = new Employee
            {
                Id = 00011,
                Name = "平澤彰久",
                HireDate = DateTime.Now,
            };
            new Employee
            {
                Id = 00011,
                Name = "平澤彰久",
                HireDate = DateTime.Now,
            };
            using (var writter = XmlWriter.Create(v))
            {
                var serialize = new DataContractSerializer(emp.GetType());
                serialize.WriteObject(writter, emp);
            };
        }

        private static void Exercise1_3(string v) {
            using (XmlReader reader = XmlReader.Create(v))
            {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in emps)
                {
                    Console.WriteLine("{0} {1} {2}", emp.Id, emp.Name, emp.HireDate);
                }
            }

        }

        private static void Exercise1_4(string v) {
            var emp = new Employee
            {
                Id = 00011,
                Name = "平澤彰久",
                HireDate = DateTime.Now,
            };
            new Employee
            {
                Id = 00011,
                Name = "平澤彰久",
                HireDate = DateTime.Now,
            };
            using (var stream = new FileStream(v, FileMode.Create, FileAccess.Write))
            {
                var serializer = new DataContractSerializer(
                    emp.GetType());
                serializer.WriteObject(stream, emp);
            }

        }
    }
    [DataContract]
    public class Employee2 {
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "hiredata")]
        public DateTime HireDate { get; set; }
    }
}
