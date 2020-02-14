namespace _0522class
{
    struct Student
    {
        private int id;
        private string firstname;
        private string lastname;
        private Evaluation scores;
        public int Id
        {
            set => id = value;
            get => id;
        }
        public string FirstName
        {
            set => firstname = value;
            get => firstname;
        }
        public string LastName
        {
            set => lastname = value;
            get => lastname;
        }
    };
}
