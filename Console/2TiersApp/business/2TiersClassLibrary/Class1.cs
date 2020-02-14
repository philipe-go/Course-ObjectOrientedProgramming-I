using System;

namespace _2TiersClassLibrary
{
    public class Class1
    {
        private int id;
        private string name;
        private string address;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }

        public override string ToString()
        {
            return ($"student {id} - {name} - {address}");
        }
    }
}
