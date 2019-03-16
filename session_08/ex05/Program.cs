using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ex05
{
     class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Starting the program... \n Fetching data...");
            var pr = new Program();
            string result = pr.GetUsersAsync().GetAwaiter().GetResult();

            List<User> list = JsonConvert.DeserializeObject<List<User>>(result);

            System.Console.WriteLine(list);
            foreach(User u in list) {
                System.Console.WriteLine(u.Id);
                System.Console.WriteLine(u.Name);
            }
            System.Console.WriteLine("Fetching has been called ...");
        }


        public async Task<string> GetUsersAsync() {

           var client = new HttpClient();

            Task<String> users = client.GetStringAsync("https://jsonplaceholder.typicode.com/users");

            System.Console.WriteLine("Write something in between fetching");

            string result = await users;

            return result;
        }
    }

    class User {

        public string Id {get; set;}
        public string Name {get; set;}
    }
}
