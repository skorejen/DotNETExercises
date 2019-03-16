using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            IExplodable<double> bomb = new Bomb<double>();

            bomb.Explode(5.0);
            IExplodable<string> bomb1 = new Bomb<string>();
            bomb1.Explode("blah");

        }
    }

    interface IExplodable<T>
    {
        void Explode(T radius);
    }

    class Bomb<T> : IExplodable<T>
    {
        public void Explode(T radius)
        {

            Type genType = typeof(T);
            if (genType == typeof(double))
            {

                Console.WriteLine("BOOM witha radius of" + Math.Pow(Convert.ToDouble(radius), 2) * Math.PI);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
