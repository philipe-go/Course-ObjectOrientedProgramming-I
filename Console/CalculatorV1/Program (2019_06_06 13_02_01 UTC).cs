using System;

namespace CalculatorV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1, numb2;
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
                numb1 = Convert.ToInt32(input);
                Console.Write("Enter second integer number: ");
                input = Console.ReadLine();
                numb2 = Convert.ToInt32(input);

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
                            Console.WriteLine("\nThe result is: " + (numb1 + numb2));
                        }
                        goto Start;
                    case 2:
                        {
                            Console.WriteLine("\nThe result is: " + (numb1 - numb2));
                        }
                        goto Start;
                    case 3:
                        {
                            Console.WriteLine("\nThe result is: " + (numb1 * numb2));
                        }
                        goto Start;
                    case 4:
                        {
                            Console.WriteLine("\nThe result is: " + (numb1 / numb2) + " with a reminder of " + (numb1%numb2));
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
