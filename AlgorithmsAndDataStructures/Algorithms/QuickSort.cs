using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public static class QuickSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            //THIS SORTING ALGORITHM USES THE IDEA OF DIVIDE AND CONQUER
            //IT FINDS THE ELEMENT CALLED PIVOT WHICH DIVIDES THE ARRAY INTO TWO PARTS
            //ELEMENTS IN THE LEFT PART ARE SMALLER THAN PIVOT AND ELEMENT IN THE RIGHT PART ARE GREATER THAN PIVOT (IT IS PARTITIONING)
            //THIS ALGORITHMS USES A RECURSION
            //TIME COMPLEXITY OF THAT ALGORITHM IS O(n*log(n)) OR O(n^2)

            Sort(array, 0, array.Length - 1);
        }

        private static T[] Sort<T>(T[] array, int lower, int upper) where T : IComparable
        {
            if(lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            }
            return array;
        }

        private static int Partition<T>(T[] array, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = array[lower]; //OR ARRAY[(lower + upper)/2]
            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; };
                while (array[j].CompareTo(pivot) > 0) { j--; };
                if(i >= j)
                {
                    break;
                }
                Swap(array, i, j);
            }
            while (i <= j);
            return j;
        }

        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
