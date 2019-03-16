using System;
using System.Collections.Generic;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> ints = new Stack<int>();
            Stack<string> strings = new Stack<string>();

            Program.pushItems(ints, 1, 2, 3, 4, 5, 6);
            Program.pushItems(strings, "blah blah", "drink a lot", "matej lalala");

            foreach (int num in ints)
            {

                Console.WriteLine(num.ToString());
            }

            foreach (string word in strings)
            {

                Console.WriteLine(word.ToString());
            }

        }

        public static void pushItems<T>(Stack<T> stack, params T[] items)
        {


            foreach (T obj in items)
            {
                Console.WriteLine(items.GetType());

                stack.Push(obj);
            }


        }
    }




}
