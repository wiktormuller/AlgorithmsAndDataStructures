﻿using AlgorithmsAndDataStructures.Algorithms;
using AlgorithmsAndDataStructures.DataStructures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

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
            Console.WriteLine();


            //ARRAY LIST - IT IS COLLECTION WHERE TYPE IS OBJECT (IS NOT STRONGLY TYPED)
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.AddRange(new int[] { 6, 3, 8 });
            arrayList.AddRange(new object[] { "Jakub", "Krzysztof" });
            arrayList.Insert(5, 7.9);
            arrayList.Remove(5);
            int arrayValue = (int)arrayList[2];
            Console.WriteLine(arrayValue);
            int arrayCount = arrayList.Count;   //NUMBER OF ELEMENTS IN LIST
            int arrayCapacity = arrayList.Capacity; //SIZE OF LIST WITH SPACE FOR FUTURE VALUES
            bool containsJakub = arrayList.Contains("Jakub");   //CHECK IF THE POSITION OF VALUES
            int whichIndex = arrayList.IndexOf(5);  //CHECK THE POSITION WHERE THE VALUES IS (IF NOT THEN RETURN -1)
            Console.WriteLine();


            //GENERIC LIST (IS STRONGLY TYPED)
            //AVERAGE VALUE
            List<double> numbers = new List<double>();
            do
            {
                Console.Write("Insert the value: ");
                string numberString = Console.ReadLine();
                if (!double.TryParse(numberString, NumberStyles.Float, new NumberFormatInfo(), out double number))
                {
                    break;
                }
                numbers.Add(number);
                Console.WriteLine($"Average value: {numbers.Average()}");
            }
            while (true);
            Console.WriteLine();


            //GENERIC LIST
            //LIST OF PEOPLE
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Marcin", Age = 29, Country = CountryEnum.DE });
            people.Add(new Person() { Name = "Sabina", Age = 18, Country = CountryEnum.PL });
            people.Add(new Person() { Name = "Anna", Age = 25, Country = CountryEnum.UK });
            List<Person> results = people.OrderBy(p => p.Name).ToList();

            foreach(Person person in results)
            {
                Console.WriteLine($"{person.Name} (age {person.Age}) from {person.Country}.");
            }
            Console.WriteLine();


            //SORTED LIST - IT IS KEY-VALUE PAIRS (WHERE KEY HAVE TO BE UNIQUE)
            //ADDRESS BOOK - WHERE VALUES ARE AUTOMATICLY SORTED BY THEM KEYS
            SortedList<string, Person> addresses = new SortedList<string, Person>();
            addresses.Add("Marcin", new Person() { Name = "Marcin",  Age = 29, Country = CountryEnum.DE });
            addresses.Add("Sabina", new Person() { Name = "Sabina", Age = 18, Country = CountryEnum.PL });
            addresses.Add("Anna", new Person() { Name = "Anna", Age = 25, Country = CountryEnum.UK });

            foreach (var address in addresses)  //WHY KEYPAIRVALUE DOES NOT WORK???
            {
                Console.WriteLine($"{address.Value.Name} (age {address.Value.Age}) from {address.Value.Country}.");
            }
            Console.WriteLine();


            //LIKED LIST - THERE IS SINGLE OR DOUBLE LINKED LIST WHERE WE CAN USE THE NEXT OR PREVIOUS PROPERTY
            //EBOOK READER
            Page pageFirst = new Page() { Content = "Nowadays..." };
            Page pageSecond = new Page() { Content = "Elaboration of that..." };
            Page pageThird = new Page() { Content = "A huge number of..." };
            Page pageFourth = new Page() { Content = "Do you know..." };
            Page pageFifth = new Page() { Content = "Let's consider..." };
            Page pageSixth = new Page() { Content = "Do you aware..." };
            LinkedList<Page> pages = new LinkedList<Page>();
            pages.AddLast(pageSecond);
            LinkedListNode<Page> nodePageFourth = pages.AddLast(pageFourth);
            pages.AddLast(pageSixth);
            pages.AddFirst(pageFirst);
            pages.AddBefore(nodePageFourth, pageThird);
            pages.AddAfter(nodePageFourth, pageFifth);

            //CIRCULAR LINKED LIST
            CircularLinkedList<string> categories = new CircularLinkedList<string>();
            categories.AddLast("Sport");
            categories.AddLast("Kultura");
            categories.AddLast("Historia");
            categories.AddLast("Geografia");
            categories.AddLast("Ludzie");
            categories.AddLast("Technologia");
            categories.AddLast("Przyroda");
            categories.AddLast("Fizyka");

            Random random = new Random();
            int totalTime = 0;
            int remainingTime = 0;
            foreach(string category in categories)
            {
                if(remainingTime <= 0)
                {
                    Console.WriteLine("Press [Enter] to start or other key to leave.");
                    switch(Console.ReadKey().Key)
                    {
                        case ConsoleKey.Enter:
                            totalTime = random.Next(1000, 5000);
                            remainingTime = totalTime;
                            break;
                        default:
                            return;
                    }
                }
                int categoryTime = (-450 * remainingTime) / (totalTime - 50) + 500 + (22500 / (totalTime - 50));
                remainingTime -= categoryTime;
                Thread.Sleep(categoryTime);

                Console.ForegroundColor = remainingTime <= 0 ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.WriteLine(category);
                Console.ForegroundColor = ConsoleColor.Gray;
            }


            //STACK
            //REVERSE THE WORD
            //STACK AND LIST ARE LIMITED ACCESS DATA STRUCTURES
            Stack<char> chars = new Stack<char>();
            foreach(char c in "WORD")
            {
                chars.Push(c);
            }
            while(chars.Count > 0)
            {
                Console.Write(chars.Pop());
            }


            //QUEUE
            //JOB QUEUE
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Make a website");
            tasks.Enqueue("Code review");
            tasks.Enqueue("Deployment");

            foreach(string task in tasks)
            {
                Console.WriteLine(tasks.Dequeue());
            }


            //HASH TABLE
            Hashtable phoneBook = new Hashtable()
            {
                {"Marcin Jamro", "000-000-000" },
                {"Jan Kowalski", "111-111-111" }
            };
            phoneBook["Liliana Kowalska"] = "333-333-333";
            string hashValue = (string)phoneBook["Jan Kowalski"];   //THE CAST IS NECCESSARY BECAUSE HASHTABLE REPRESENT NONGENERIC VARIANT OF ARRAY WITH HASHTABLE
            Console.WriteLine($"Hashtable value: {hashValue}");


            //DICTIONARY
            //IT IS A GENERIC VERSION OF HASHTABLE
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"Key 1", "Value 1" },
                {"Key 2", "Value 2" }
            };
            dictionary.Add("Key 3", "Value 3");
            string dictionaryValue = dictionary["Key 1"];
            Console.WriteLine($"Dictionary value: {dictionaryValue}");

            foreach(KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }


            //SORTED DICTIONARY
            //SIMILAR TO SORTEDLIST BUT THE SORTED DICTIONARY IS FASTER WHEN WE ADD OR REMOVE ELEMENTS
            SortedDictionary<string, string> definitions = new SortedDictionary<string, string>()
            {
                { "New York", "This is the city in the USA"},
                { "Warsaw", "This is city in Poland"},
                { "London", "This is city in the UK"}
            };
            foreach(KeyValuePair<string, string> definition in definitions)
            {
                Console.WriteLine($"{definition.Key} : {definition.Value}");
            }


            //SET
            //UNION (SUMA), INTERSECTION (CZĘŚĆ WSPÓLNA), SET SUBSTRACTION (RÓŻNICA ZBIORÓW), SYMMETRIC DIFFERENCE (RÓŻNICA ARYTMETYCZNA - SUMA BEZ CZĘŚCI WSPÓLNEJ)
            //VALUES IN SET ARE UNIQUE
            HashSet<int> usedCoupons = new HashSet<int>();
            usedCoupons.Add(100);
            usedCoupons.Add(200);
            if(usedCoupons.Contains(100))
            {
                Console.WriteLine("The set contains a value: 100");
            }

            //SORTEDSET
            //IT IS A COMBINATION OF SORTEDLIST AND HASHSET
            //USE THAT WHEN YOU NEED ORDERED COLLECTION DIFFERENT OBJECTS WITHOUT REPEATS
            List<string> names = new List<string>()
            {
                "Marcin",
                "Maria",
                "Jakub",
                "Albert",
                "Liliana",
                "Emilia",
                "Marcin",
                "Jakub",
                "Janinca"
            };
            SortedSet<string> sorted = new SortedSet<string>(names, Comparer<string>.Create((a, b) => a.ToLower().CompareTo(b.ToLower())));
            foreach(string name in sorted)
            {
                Console.WriteLine(name);
            }


            //TREE
            Tree<int> tree = new Tree<int>();
            tree.Root = new TreeNode<int>() { Data = 100 };
            tree.Root.Children = new List<TreeNode<int>>
            {
                new TreeNode<int>() {Data = 50, Parent = tree.Root},
                new TreeNode<int>() {Data = 1, Parent = tree.Root},
                new TreeNode<int>() {Data = 150, Parent = tree.Root}
            };
            tree.Root.Children[2].Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>()
                { Data = 30, Parent = tree.Root.Children[2] }
            };

            Console.ReadKey();
        }

        //ONE DIMENSION ARRAY
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

        //MULTI DIMENSION ARRAY
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


        //JAGGED ARRAY
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
