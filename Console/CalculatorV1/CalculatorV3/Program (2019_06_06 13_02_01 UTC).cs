using System;

namespace CalculatorV3
{
    struct Calculator{
        //variables declaration
        private int numb1, numb2;

        //setter and getter for integer variables declared
        public int Numb1 {
            get => this.numb1;
            set => this.numb1 = value;
        }
        public int Numb2
        {
            get => this.numb2;
            set => this.numb2 = value;
        }

        //public functions to access results
        public int Addition()
        {
            return (this.numb1 + this.numb2);
        }
        public int Subtraction()
        {
            return (this.numb1 - this.numb2);
        }
        public int Multiplication()
        {
            return (this.numb1 * this.numb2);
        }
        public int Division()
        {
            return (this.numb1 / this.numb2);
        }
        public int Reminder()
        {
            return (this.numb1 % this.numb2); ;
        }
    };

    class Program
    {

        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            int option;
            string input;
            char quit;

            do
            {
                //clear screen type
                Console.Clear();

                //print request for numbers input
                Console.Write("Enter one integer number: ");
                input = Console.ReadLine();
                Calc.Numb1 = Convert.ToInt32(input);
                Console.Write("Enter second integer number: ");
                input = Console.ReadLine();
                Calc.Numb2 = Convert.ToInt32(input);

            //create a start point
            Start:

                //menu for desired operation
                Console.WriteLine("\n ------MENU------ \n");
                Console.WriteLine(" 1 - addition\n 2 - subtraction\n 3 - multiplication\n 4 - division\n 5 - exit\n");
                Console.Write("Enter an option from the menu above: ");

                input = Console.ReadLine();
                option = Convert.ToInt32(input);

                //switch statement to handle menu option selected
                switch (option)

                {
                    case 1:
                        {
                            Console.WriteLine("\nThe result is: " + Calc.Addition());
                        }
                        goto Start;
                    case 2:
                        {
                            Console.WriteLine("\nThe result is: " + Calc.Subtraction());
                        }
                        goto Start;
                    case 3:
                        {
                            Console.WriteLine("\nThe result is: " + Calc.Multiplication());
                        }
                        goto Start;
                    case 4:
                        {
                            if (Calc.Numb2 == 0) { Console.WriteLine("\n<> This division not possible <>"); }
                            else Console.WriteLine("\nThe result is: " + Calc.Division() + " with a reminder of " + Calc.Reminder());
                        }
                        goto Start;
                    case 5:
                        {
                            Console.WriteLine("\nGood Bye");
                        }
                        break;
                }

                //option to enter new numbers if desired before quit the program
                Console.Write("\nDo you want to enter new numbers? (y/n) ");
                input = Console.ReadLine();
                quit = Convert.ToChar(input);

            } while ((quit == 'Y') || (quit == 'y'));
        } //closing static void main
    } //closing class program.cs
}
