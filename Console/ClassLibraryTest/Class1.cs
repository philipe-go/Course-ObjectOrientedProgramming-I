using System;

namespace ClassLibraryTest
{
    public class Class1
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return ($"student {id} - {name}");
        }
    }
}
