using System;
using System.Collections.Generic;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            Random rnd = new Random();
            for (int i = 0; i <= 10; i++)
            {
                double weight = rnd.Next(1, 10);
                int speed = rnd.Next(5, 20);
                list.Add(new Animal("Dog", weight, speed));
            }

            foreach (Animal animal in list)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.WriteLine(list[0].CompareTo(list[1]));

            list.Sort();

            foreach (Animal animal in list)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
