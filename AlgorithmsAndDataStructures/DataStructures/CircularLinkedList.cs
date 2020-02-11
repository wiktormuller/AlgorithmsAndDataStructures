using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class CircularLinkedList<T> : LinkedList<T>
    {
        public new IEnumerator GetEnumerator()
        {
            return new CircularLinkedListEnumerator<T>(this);
        }
    }
}
