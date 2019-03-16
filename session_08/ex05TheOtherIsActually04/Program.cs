using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ex05TheOtherIsActually04
{
    class Program
    {
         static void Main(string[] args)
        {
            System.Console.WriteLine("Starting the program... \n Fetching data...");
            var pr = new Program();
            string result = pr.GetViaContent()
            .GetAwaiter().GetResult();
           
            System.Console.WriteLine("Fetching has been finished ...");
        }


        public async Task<string> GetViaContent() {

           var client = new HttpClient();

            Task<String> users = client.GetStringAsync("https://via.dk");
            var watch = System.Diagnostics.Stopwatch.StartNew();

            string result = await users;
            watch.Stop();
            System.Console.WriteLine($"The operation took {watch.ElapsedMilliseconds} miliseconds");

            return result;
        }
    }
}
