using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { FirstName = "Jhon", LastName = "Black", Ssn = 2552 };

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("BinaryFile.bin", FileMode.Create))
            {

                formatter.Serialize(stream, person);


            }
            using (Stream stream = new FileStream("BinaryFile.bin", FileMode.Open))
            {
                var obj = (Person)formatter.Deserialize(stream);
                System.Console.WriteLine(obj.FirstName + " " + obj.LastName);
            }


            // JSON writing and reading with Person object

            using (Stream stream = new FileStream("JsonInside.txt", FileMode.Create))
            {
                // DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
                // ser.WriteObject(stream, person);


            }

            using (var sw = new StreamWriter("JsonInside.txt", true))
            {
                string json = JsonConvert.SerializeObject(person);


                sw.WriteLineAsync(json);
                sw.WriteLineAsync(json);
                sw.WriteLineAsync(json);
            }

            using (var sr = new StreamReader("JsonInside.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Person p = JsonConvert.DeserializeObject<Person>(line);
                    System.Console.WriteLine(p.FirstName);
                }
            }



        }
    }
    [DataContract]
    [Serializable]
    class Person
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int Ssn { get; set; }
    }
}
