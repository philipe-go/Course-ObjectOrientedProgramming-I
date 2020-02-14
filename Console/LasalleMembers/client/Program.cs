using System;
using LasalleMembers.bus;
using System.Collections;

namespace LasalleMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listofMember = new ArrayList();
            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("************ Lasalle Members Management Application ************\n");
                Console.WriteLine("\t - 1 - Employee\n\t - 2 - Student\n\t - 3 - Print\n\t - 4 - Exit\n");
                Console.Write("enter the choice of from the menu above: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Employee input = new Employee();
                            Console.WriteLine("\nenter the employee informations as below: ");
                            Console.Write("\t - ID: ");
                            input.Id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\t - First Name: ");
                            input.FirstName = Console.ReadLine();
                            Console.Write("\t - Last Name: ");
                            input.LastName = Console.ReadLine();
                            Console.Write("\t - Hours Per Week: ");
                            input.HrsPerWeek = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\t - Hourly Rate: ");
                            input.HourlyRate = Convert.ToDouble(Console.ReadLine());

                            listofMember.Add(input);
                        }
                        break;

                    case 2:
                        {
                            Student input = new Student();
                            Console.WriteLine("\nenter the student informations as below: ");
                            Console.Write("\t - ID: ");
                            input.Id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\t - First Name: ");
                            input.FirstName = Console.ReadLine();
                            Console.Write("\t - Last Name: ");
                            input.LastName = Console.ReadLine();
                            Console.Write("\t - First Fees: ");
                            input.FirstFees = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\t - Fee per Session: ");
                            input.FeesPerSession = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\t - Number of Sessions: ");
                            input.NumberOfSessions = Convert.ToInt32(Console.ReadLine());

                            listofMember.Add(input);
                        }
                        break;

                    case 3:
                        {

                            if (listofMember.Count != 0)
                            {
                                Console.WriteLine("\n>>>>>List of Employees<<<<<");

                                foreach (Object element in listofMember)
                                {
                                    Console.WriteLine();

                                    if (element.GetType() == typeof(Employee))
                                    {
                                        Console.WriteLine(element);
                                    }
                                }

                                Console.WriteLine("\n>>>>>List of Students<<<<<");

                                foreach (Object element in listofMember)
                                {
                                    Console.WriteLine();

                                    if (element.GetType() == typeof(Student))
                                    {
                                        Console.WriteLine(element);
                                    }
                                }

                                Console.ReadLine();
                            }
                            else { Console.WriteLine("\nThe members list is empty"); }
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("\n\n<> GOOD BYE <>");
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("You entered a wrong option. Try a correct option number.");
                        }
                        break;
                }

            } while (choice != 4);

            Console.ReadLine();
        }
    }
}
