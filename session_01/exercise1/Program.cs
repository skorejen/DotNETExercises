using System;
using DNB.MathLib;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // var looper = new Looper();
            // looper.loop();

            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            var calc = new Calculator();

            var program = new Program();

            var x = 5;
            var y = 10;
            program.addFive(ref x, ref y);
            Console.WriteLine($"{x} and {y}");

            Console.WriteLine("Write your name: ");

            var choice = Console.ReadLine();

            var reversedName = program.reverseName(choice);

            Console.WriteLine(reversedName);

            Console.WriteLine("Write a text longer than 20 characters");
            choice = Console.ReadLine();
            Console.WriteLine(StringUtility.SummarizeText(choice));




        }

        public void addFive(ref int x, ref int y)
        {
            x += 5;
            y += 5;
        }

        public string reverseName(String name)
        {

            var length = name.Length;
            var reversedName = new string[length];
            var a = 0;
            char character;

            for (int i = length - 1; i >= 0; i--)
            {
                character = name[i];
                reversedName[a] = character.ToString();
                a++;
            }
            return String.Join("", reversedName);

        }
    }
}
