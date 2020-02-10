using AlgorithmsAndDataStructures.Algorithms;
using AlgorithmsAndDataStructures.DataStructures;
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            oneDimensionArray();
            multiDimensionArray();
            jaggedArray();

            //SELECTION SORT
            int[] integerValues = { -11, 12, -42, 0, 1, 90, 58, 6, -9};
            SelectionSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));    //JOIN ALL ELEMENTS FORM THE ARRAY
            Console.WriteLine();

            string[] stringValues = { "Maria", "Marcin", "Anna", "Jakub", "Jerzy", "Nikola" };
            SelectionSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
            Console.WriteLine();

            //INSERTION SORT
            int[] otherValues = { 8, 1, 5, -4, -5, 22, -13 };
            InsertionSort.Sort(otherValues);
            Console.WriteLine(string.Join(" | ", otherValues));
            Console.WriteLine();

            //BUBBLE SORT
            int[] someValues = { 22, 1, -5, -4, -4, 2, 8, 5 };
            BubbleSort.Sort(someValues);
            Console.WriteLine(string.Join(" | ", someValues));
            Console.WriteLine();

            //QUICK SORT
            int[] differentValues = { 0, 2, -3, 18, -18, 15, 6, 7};
            QuickSort.Sort(differentValues);
            Console.WriteLine(string.Join(" | ", differentValues));

            Console.ReadKey();
        }

        public static void oneDimensionArray()  //NAME OF DAYS IN ACTUAL MONTH (CANNOT CHANGE LENGTH OF ANY ARRAY)
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

        public static void multiDimensionArray()   //MULTIPLICATION TABLE AND MAP OF GAME
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

        public static void jaggedArray()    //YEAR TRANSPORTATION SCHEDULE
        {
            //EXAMPLE
            //int[][] numbers = new int[4][];
            //numbers[0] = new int[] {0, 5, -9}

            Random random = new Random();
            int transportTypesCount = Enum.GetNames(typeof(TransportEnum)).Length;
            TransportEnum[][] transport = new TransportEnum[12][];
            for(int month = 1; month <= 12; month++)
            {
                int daysCount = DateTime.DaysInMonth(DateTime.Now.Year, month);
                transport[month - 1] = new TransportEnum[daysCount];
                for(int day = 1; day <= daysCount; day++)
                {
                    int randomType = random.Next(transportTypesCount);
                    transport[month - 1][day - 1] = (TransportEnum)randomType;
                }
            }

            string[] monthNames = GetMonthNames();
            int monthNamesPart = monthNames.Max(n => n.Length) + 2;
            for(int month = 1; month <= transport.Length; month++)
            {
                Console.Write($"{monthNames[month - 1]}:".PadRight(monthNamesPart));
                for(int day = 1; day <= transport[month - 1].Length; day++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = transport[month - 1][day - 1].GetColor();
                    Console.Write(transport[month - 1][day - 1].GetChar());
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        private static string[] GetMonthNames()
        {
            string[] names = new string[12];
            for(int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("pl"));
                names[month - 1] = name;
            }
            return names;
        }

        
    }
}
