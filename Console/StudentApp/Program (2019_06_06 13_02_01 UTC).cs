//program.cs
//created by philipe gouveia @ may 29th, 2019
//project created to practice implementation of OOP concepts into a Student Management Application

using System;
using System.Collections;

namespace StudentApp
{
    public class Grade
    {
        private double midterm;
        private double final;
        private double project;
        public double Midterm { get => midterm; set => midterm = value; }
        public double Final { get => final; set => final = value; }
        public double Project { get => project; set => project = value; }

        public Grade()
        {
            this.Midterm = 0.00;
            this.Final = 0.00;
            this.Project = 0.00;
        }
        public Grade(double mt, double pro, double fin)
        {
            this.Midterm = mt;
            this.Project = pro;
            this.Final = fin;
        }
        public override string ToString()
        {
            return this.Midterm + " - " + this.Project + " - " + this.Final;
        }
    }
    public class Person
    {
        private string firstname, lastname;
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }

        public Person()
        {
            this.firstname = "a";
            this.lastname = "a";
        }
        public Person(string fn, string ln)
        {
            this.firstname = fn;
            this.lastname = ln;
        }
        public override string ToString()
        {
            return this.firstname + this.lastname + " - ";
        }
    }
    public class Student : Person
    {
        private int id;
        private Grade scores;
        public int Id { get => id; set => id = value; }
        public Grade Scores { get => scores; set => scores = value; }
        public Student() : base()
        {
            this.id = 0;
            scores = new Grade();
        }
        public Student(int id, string fn, string ln, double test1, double test2, double test3) : base(fn, ln)
        {
            this.id = id;
            Scores.Midterm = test1;
            Scores.Project = test2;
            Scores.Final = test3;
            Firstname = fn;
            Lastname = ln;
        }
        public override string ToString()
        {
            return this.id + " - " + base.ToString() + Scores.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentlist = new ArrayList();
            string input;

        Start:
            Console.Clear();
            Student student = new Student();
            Console.Write("\nEnter the student Informations: \n");

            Console.Write("\tStudent ID: ");
            student.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tFirst name: ");
            student.Firstname = Console.ReadLine();
            Console.Write("\tLast name: ");
            student.Lastname = Console.ReadLine();
            Console.WriteLine("Enter the scores as per below:");
            Console.Write("\tFirst Test: ");
            student.Scores.Midterm = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tProject: ");
            student.Scores.Project = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tFinal Test: ");
            student.Scores.Final = Convert.ToDouble(Console.ReadLine());

            studentlist.Add(student);

            Console.Write("\nDo you want to enter another student? (y/n) ");
            input = Console.ReadLine();
            if ((input == "y") || (input == "Y"))
            {
                goto Start;
            }
            else
            {
                Console.WriteLine("");
                foreach (Student element in studentlist)
                {
                    Console.WriteLine("\t" + element);
                }
            }
            Console.WriteLine("\n\n <> GOOD BYE <> \a\n");
            Console.ReadKey();
        }
    }
}
