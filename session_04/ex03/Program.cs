using System;
using System.IO;
using System.Threading.Tasks;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            string data = "Nothing interesting here :)))";
            string data2 = "Nothing interesting here :))))";

            using (var sw = new StreamWriter("file1.txt", false))
            {
                sw.Write(data);

            }

            using (var sw = new StreamWriter("file2.txt", false))
            {
                sw.Write(data2);

            }



            Reader reader1 = new Reader("file1.txt");
            Reader reader2 = new Reader("file2.txt");





            Task file1Reader = new Task(() => reader1.Read());
            System.Console.WriteLine("Task 1 running");
            Task file2Reader = new Task(() => reader2.Read());
            System.Console.WriteLine("Task 2 running");

            file1Reader.Start();
            file2Reader.Start();


            System.Console.WriteLine(reader1.compareTo(reader2));
        }
    }
}
