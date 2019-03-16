using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy { Damage = 5 };
            player.Shout(enemy);
            player.Shout("BLAH");
            player.Shout(5);
        }
    }

    class Player
    {
        public void Shout(string arg)
        {
            System.Console.WriteLine(arg);
        }
        public void Shout(int num)
        {
            System.Console.WriteLine($"{num} is my lucky number!");
        }
        public void Shout(Enemy enemy)
        {
            System.Console.WriteLine($"The enemy can do {enemy.Damage} to me.");
        }

    }

    class Enemy
    {
        public int Damage { get; set; }
    }
}
