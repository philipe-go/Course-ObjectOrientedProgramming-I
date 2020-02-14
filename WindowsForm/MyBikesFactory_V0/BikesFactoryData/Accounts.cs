//created by Philipe Gouveia @ August 3rd, 2019
//subject: create a Bike Management App as project for the 420-JV4-AS (OOP and Concepts I) - LaSalle College Montreal

namespace BikesFactoryData
{
    public class Accounts
    {
        private string user;
        private string password;

        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }

        public Accounts()
        {
            this.user = "guest";
            this.password = "guest";
        }

        public Accounts(string user, string password)
        {
            this.user = user;
            this.password = password;
        }
    }
}
