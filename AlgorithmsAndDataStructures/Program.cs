using AlgorithmsAndDataStructures.DataStructures;
using System;
using System.Globalization;
using System.Text;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            oneDimensionArray();
            multiDimensionArray();

            Console.ReadKey();
        }

        public static void oneDimensionArray()  //NAME OF DAYS IN ACTUAL MONTH
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
            Console.WriteLine();
        }

        public static void multiDimensionArray()   //MULTIPLICATION TABLE
        {
            int[,] results = new int[10, 10]; //[rows, columns]

            for(int i = 0; i < results.GetLength(0); i++)   //GetLength(dimension)
            {
                for(int j = 0; j < results.GetLength(1); j++)
                {
                    results[i, j] = (i + 1) * (j + 1);
                }
            }
            for (int i = 0; i < results.GetLength(0); i++)
            {
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    Console.Write("{0,4}", results[i,j]);   //DISPLAY EVERY CHAR WITH 4 CHARS IN CONSOLE
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            TerrainEnum[,] map =
            {
                { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS },
                { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER, TerrainEnum.WATER }
            };
            Console.OutputEncoding = UTF8Encoding.UTF8;
            
            for(int row = 0; row < map.GetLength(0); row++)
            {
                for(int column = 0; column < map.GetLength(1); column++)
                {
                    Console.ForegroundColor = map[row, column].GetColor();
                    Console.Write(map[row, column].GetChar() + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
