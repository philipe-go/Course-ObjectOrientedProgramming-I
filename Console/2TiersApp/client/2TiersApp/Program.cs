using System;
using _2TiersClassLibrary;

namespace _2TiersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 test = new Class1();
            test.Id = 124;
            test.Name = "test";
            test.Address = "1234 LaSalle College";

            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
