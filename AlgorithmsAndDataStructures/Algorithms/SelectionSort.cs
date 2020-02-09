using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            //ARRAY IS CONSIDERED INTO TWO PARTS UNSORTED AND SORTED (INITIALLY WHOLE ARRAY IS UNSORTED)
            //SELECT THE LOWEST ELEMENT IN THE REMAINING ARRAY
            //BRING IT INTO STARTING POSITION (SWAP)
            //CHANGE THE COUNTER FOR UNSORTED ARRAY BY ONE

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }
                Swap(array, i, minIndex);
            }
        }
        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
