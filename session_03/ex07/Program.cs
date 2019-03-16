using System;

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Calculator.Add(1, 2, 3, 4, 5, 6, 7, 8, 8));
        }


    }

    class Calculator
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }
    }
}
