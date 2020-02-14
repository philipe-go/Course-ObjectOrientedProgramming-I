using System;

namespace _0522class
{
    class Program
    {
        static void Main(string[] args)
        {
            char option;

            do
            {

                Console.Clear();

                Student Studentlist = new Student();
                string input, output;

                Console.Write("Enter the student ID: ");
                input = Console.ReadLine();
                Studentlist.Id = Convert.ToInt32(input);
                Console.Write("Enter the student first Name: ");
                Studentlist.FirstName = Console.ReadLine();
                Console.Write("Enter the student last name: ");
                Studentlist.LastName = Console.ReadLine();

                Console.Write("\nDo you want to enter the scores now or just print the informations? (y/n) ");
                input = Console.ReadLine();

                output = Studentlist.Id + " - " + Studentlist.FirstName + " - " + Studentlist.LastName;

                if ((input == "y") || (input == "Y"))
                {
                    Console.WriteLine("\nStudent Informations: ");
                    Console.WriteLine(output);
                }

                Console.WriteLine("\nEnter now the scores.\n");
                Console.Write("Enter the first term score: ");
                input = Console.ReadLine();
                Studentlist.scores.MidTerm = Convert.ToDouble(input);
                Console.Write("Enter the Project score:  ");
                input = Console.ReadLine();
                Studentlist.scores.Project = Convert.ToDouble(input);
                Console.Write("Enter the final test score:  ");
                input = Console.ReadLine();
                Studentlist.scores.Final = Convert.ToDouble(input);

                Console.WriteLine("\nStudent Informations: ");
                Console.WriteLine(output);
                Console.Write("Average score: ");
                Console.WriteLine(Studentlist.scores.Average);

                if (Studentlist.scores.Average >= 60)
                {
                    Console.WriteLine("\n\t<> You are approved. <>");
                }
                else { Console.WriteLine("\n\t (-.-) You will have to try again. (-.-) "); }

                Console.Write("\nDo you want to quit? (y/n) ");
                option = Convert.ToChar(Console.ReadLine());

                 
            } while (option != 'y');
        }
    }
}
