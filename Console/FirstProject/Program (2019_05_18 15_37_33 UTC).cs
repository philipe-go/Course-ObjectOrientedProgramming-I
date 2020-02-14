using System;

namespace FirstProject
{
    struct Student
    {
        private int id;
        private string fn, ln;

        //create setter and getter services
        public void SetId(int id)
        {
            this.id = id; //this is to use the private variable inside the object (class or struct)
        }
        public int GetId()
        {
            return this.id;
        }
        public void Setfn(string fn)
        {
            this.fn = fn; //this is to use the private variable inside the object (class or struct)
        }
        public string Getfn()
        {
            return this.fn;
        }
        public void Setln(string ln)
        {
            this.ln = ln; //this is to use the private variable inside the object (class or struct)
        }
        public string Getln()
        {
            return this.ln;
        }


    };
    
    class Program
    {
        static void Main(string[] args)
        {
            //variables declaration
            string input, output;
            Student s1 = new Student(); //function constructor 'Student()' due to encapsulation do not access the object variables 

            //inputing informations into struct declared
            Console.Write("input id: ");
            input = Console.ReadLine();
            s1.SetId(Convert.ToInt32(input));
            Console.Write("input fn: ");
            s1.Setfn(Console.ReadLine());
            Console.Write("input ln: ");
            s1.Setln(Console.ReadLine());

            //concatenate all struct variables getters
            output = s1.GetId() + " - " + s1.Getfn() + " - " + s1.Getln();

            //output informations entered after being concatenated
            Console.Write("Student info: ");
            Console.WriteLine(output);

            //such as system("pause")
            Console.ReadKey();
        }
    }
}
