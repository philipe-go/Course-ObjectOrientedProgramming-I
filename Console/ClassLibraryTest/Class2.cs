using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTest
{
    public class Class2
    {
        private int age;
        private string address;

        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }

        public override string ToString()
        {
            return ($"student {age} - {address}");
        }
    }
}
