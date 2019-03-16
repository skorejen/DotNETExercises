using System;
using System.Collections.Generic;

namespace ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Predicate<Car> pred = Car.checkBlueCar;



            cars.Add(new Car { Color = "Blue", EngineSize = 5.0, FuelEconomy = 9.0 });
            cars.Add(new Car { Color = "Red", EngineSize = 6.0, FuelEconomy = 9.5 });
            cars.Add(new Car { Color = "Green", EngineSize = 4.5, FuelEconomy = 11.0 });

            System.Console.WriteLine("Searching for cars with engine size smaller or equal 5.0");
            // Engine size smaller than 8
            foreach (Car car in cars.FindAll(car => car.EngineSize <= 5.0 ? true : false))
            {
                System.Console.WriteLine(car.ToString());
            }
            System.Console.WriteLine("Searching for cars with color blue");
            // Blue color cars
            foreach (Car car in cars.FindAll(car => car.Color.Equals("Blue") ? true : false))
            {
                System.Console.WriteLine(car.ToString());
            }

            System.Console.WriteLine("Searching for cars that are green and their fuel economy is higher than 10");

            foreach (Car car in cars.FindAll(car => car.Color.Equals("Green") && car.FuelEconomy > 10.0 ? true : false))
            {
                System.Console.WriteLine(car.ToString());
            }


        }
    }

    class Car
    {
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public double FuelEconomy { get; set; }

        public override string ToString()
        {
            return $"Color of the car is {this.Color}, the Engine size is {this.EngineSize} and Fiel Economy is {this.FuelEconomy} / 100km";
        }

        public static bool checkBlueCar(Car car)
        {
            string x = "Blue";
            return x.Equals(car.Color) ? true : false;
        }
    }

}
