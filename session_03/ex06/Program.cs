using System;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 2000;

            string message = "";


            message = score > 1337 ? "This is a new highscore" : "You need more points to beat the highscore!";

            System.Console.WriteLine(message);


        }
    }
}
