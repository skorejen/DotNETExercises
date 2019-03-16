using System;
using System.Collections.Generic;

namespace ex03
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            Console.WriteLine(ints.GetRandomItem<int>(1));

            foreach (int num in ints)
            {
                Console.WriteLine(num);
            }

            System.Console.WriteLine("Shuffling");
            ints.ShuffleList();
            foreach (int num in ints)
            {
                Console.WriteLine(num);
            }
        }

        public static T GetRandomItem<T>(this List<T> items, int i)
        {
            Random rnd = new Random();

            return items[rnd.Next(items.Count)];
        }

        public static void ShuffleList<T>(this List<T> list)
        {
            Random rnd = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }




}
