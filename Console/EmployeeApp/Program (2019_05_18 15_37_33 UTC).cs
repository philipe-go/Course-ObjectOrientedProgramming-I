using System;

namespace EmployeeApp
{
    struct EmployeeApp
    {
        private string FN;
        private string LN;
        private string Position;
        private int Salary;

        public void GetFN(string fn)
        {
            this.FN = fn;
        }
        public void GetLN(string ln)
        {
            this.LN = ln;
        }
        public void GetPosition(string position)
        {
            this.Position = position;
        }
        public void GetSalary(int salary)
        {
            this.Salary = salary;
        }

        public string SetFN()
        {
            return FN;
        }
        public string SetLN()
        {
            return LN;
        }
        public string SetPosition()
        {
            return Position;
        }
        public int SetSalary()
        {
            return Salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input, output;
            EmployeeApp employeelist = new EmployeeApp();

            Console.Write("Enter the first name: ");
            employeelist.GetFN(Console.ReadLine());

            Console.Write("Enter the last name of the employee: ");
            employeelist.GetLN(Console.ReadLine());

            Console.Write("Enter the position of the employee: ");
            employeelist.GetPosition(Console.ReadLine());

            Console.Write("Enter the salary of the employee: ");
            input = Console.ReadLine();
            employeelist.GetSalary(Convert.ToInt32(input));

            //output = employeelist.SetFN() + " - " + employeelist.SetLN() + " - " + employeelist.SetPosition() + " - " + employeelist.SetSalary();
            Console.WriteLine(output);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
