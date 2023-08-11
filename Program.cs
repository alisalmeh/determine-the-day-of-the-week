using System;

namespace AliSalmeh_ProjectWeek4.WeekDays_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day number (between 1-7): ");

            var currentDay = (Days)Enum.Parse(typeof(Days), Console.ReadLine());
            Console.WriteLine(currentDay);
        }
    }
}