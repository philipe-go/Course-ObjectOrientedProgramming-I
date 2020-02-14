using System;

namespace TestApp
{

    struct TestApp
    {
        private int num1, num2;

        public int Num1
        {
            // get => num1;
            set => num1 = value;
        }
        public int Num2
        {
            // get => num2;
            set => num2 = value;
        }

        public int Summing()
        {
            return this.num1 + this.num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestApp Calculator = new TestApp();
            string input;

            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            Calculator.Num1 = Convert.ToInt32(input);
            Console.Write("Enter a second number: ");
            input = Console.ReadLine();
            Calculator.Num2 = Convert.ToInt32(input);

            Console.WriteLine();
            Console.WriteLine(Calculator.Summing());

            Console.ReadKey();
        }
    }
}
