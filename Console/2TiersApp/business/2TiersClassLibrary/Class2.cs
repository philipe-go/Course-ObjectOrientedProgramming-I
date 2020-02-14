using System;
using System.Collections.Generic;
using System.Text;

namespace _2TiersClassLibrary
{
    class Class2
    {
        private int age;
        private string color;
        private double weight;

        public int Age { get => age; set => age = value; }
        public string Color { get => color; set => color = value; }
        public double Weight { get => weight; set => weight = value; }

        public override string ToString()
        {
            return ($" - {age} - {color} - {weight};");
        }

    }
}
