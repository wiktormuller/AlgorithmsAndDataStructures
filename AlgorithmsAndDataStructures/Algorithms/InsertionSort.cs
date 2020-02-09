using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            //SET A MARKER FOR THE SORTED SECTION AFTER THE FIRST ELEMENT
            //REPEAT THE FOLLOWING UNTIL UNSORTED SECTION IS EMPTY:
            //SELECT THE FIRST UNSORTED ELEMENT 
            //SWAP OTHER ELEMENTS TO THE RIGHT TO CREATE THE CORRECT POSITION AND SHIFT THE UNSORTED ELEMENT
            //ADVANCE THE MARKER TO THE RIGHT ONE ELEMENT
            for(int i = 1; i < array.Length; i++)
            {
                int j = i;
                while(j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
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
