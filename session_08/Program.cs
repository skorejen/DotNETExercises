using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace session_08
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Starting the program... \n Fetching data...");
            var pr = new Program();
            string result = pr.GetUsersAsync().GetAwaiter().GetResult();
            System.Console.WriteLine(result);
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
}
