using System;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2018, 6, 5, 4, 0, 0);
            Random rnd = new Random();

            DateTime date2 = new DateTime(2018, 6, rnd.Next(5, 30), 4, 0, 0);
            DateTime date3 = new DateTime(2018, 6, rnd.Next(5, 30), 4, 0, 0);
            DateTime date4 = new DateTime(2018, 6, rnd.Next(5, 30), 4, 0, 0);

            Schedule schedule = new Schedule();
            schedule.addClass(date1, "MAths");
            schedule.addClass(date2, "Physics");
            schedule.addClass(date3, "Chemistry");
            schedule.addClass(date4, "Java");

            Console.WriteLine($"Class for a day {date1.ToString()} is {schedule[date1]}");
        }
    }
}
