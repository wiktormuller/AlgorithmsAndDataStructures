using System;
using System.Globalization;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            oneDimensionArray();

            Console.ReadKey();
        }

        public static void oneDimensionArray()
        {
            string[] days = new string[7];

            for(int day = 1; day <= 7; day++)
            {
                DateTime dayName = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);
                string name = dayName.ToString("dddd", CultureInfo.CreateSpecificCulture("pl"));
                days[day-1] = name;
            }
            foreach(string day in days)
            {
                Console.WriteLine($"-> {day}");
            }
        }
    }
}
