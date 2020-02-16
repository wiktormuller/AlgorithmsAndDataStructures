using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public CountryEnum Country { get; set; }
        public object CountryEnum { get; internal set; }
    }
}
