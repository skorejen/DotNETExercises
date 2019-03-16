using System;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            var pr = new Program();

            notifier dele;

            dele = pr.SayHello;
            dele("Rick");

            dele = pr.SayGoodbye;
            dele("Rick");

            dele += pr.SayHello;
            dele("Rick");

        }

        public delegate void notifier(string arg);

        public void SayHello(string name) => System.Console.WriteLine("Hello " + name);

        public void SayGoodbye(string name) => System.Console.WriteLine("Goodbye " + name);
    }


}
