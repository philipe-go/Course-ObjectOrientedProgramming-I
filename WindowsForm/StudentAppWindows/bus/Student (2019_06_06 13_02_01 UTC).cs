namespace StudentAppWindows.bus
{
    public class Student
    {
        private int id;
        private string firstname, lastname;

        public Address address = new Address();
        public Score scores = new Score();

        public int Id
        {
            set => this.id = value;
            get => this.id;
        }
        public string Firstname
        {
            set => this.firstname = value;
            get => this.firstname;
        }
        public string Lastname
        {
            set => this.lastname = value;
            get => this.lastname;
        }
        public Student()
        {
            this.id = 0;
            this.firstname = " default ";
            this.lastname = " default ";
        }
        public Student(int id, string fn, string ln)
        {
            this.id = id;
            this.firstname = fn;
            this.lastname = ln;
        }
        public override string ToString()
        {
            return (this.id + " - " + this.firstname +" "+ this.lastname+" - "+this.address+" - "+this.scores);
        }
    }
}
