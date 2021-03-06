﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            //COMPARE THE ADJACENT ELEMENTS THEN SWAP THEM IN SOME ORDER

            for(int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j + 1);
                    }
                    if(!isAnyChange)    //IF IN THE SERIES THERE WAS NOT A CHANGE THEN ARRAY IS SORTED SO BREAK ANY COMPARISIONS
                    {
                        break;
                    }
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
