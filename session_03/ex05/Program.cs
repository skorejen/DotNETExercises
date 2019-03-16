using System;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time { Hours = 50, Minutes = 20 } + new Time { Hours = 20, Minutes = 5 };
            System.Console.WriteLine(" Hours: " + time.Hours + " and Minutes: " + time.Minutes);

            Time time2 = new Time { Hours = 50, Minutes = 70 } + 5;
            System.Console.WriteLine(" Hours: " + time2.Hours + " and Minutes: " + time2.Minutes);


        }
    }

    class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public static Time operator +(Time t1, Time t2)
        {

            var min = t1.Minutes + t2.Minutes;
            var hoursSum = Math.Floor((double)min / 60);

            return new Time { Hours = t1.Hours + t2.Hours + (int)hoursSum, Minutes = min % 60 };

        }

        public static Time operator +(Time t1, int min)
        {
            var mins = t1.Minutes + min;
            var hoursSum = Math.Floor((double)mins / 60);

            return new Time { Hours = t1.Hours + (int)hoursSum, Minutes = min % 60 };
        }


    }
}
