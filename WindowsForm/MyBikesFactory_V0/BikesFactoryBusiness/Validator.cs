//created by Philipe Gouveia @ August 3rd, 2019
//subject: create a Bike Management App as project for the 420-JV4-AS (OOP and Concepts I) - LaSalle College Montreal

using System.Text.RegularExpressions;

namespace BikesFactoryBusiness
{
    public static class Validator
    {
        public static bool isDigit(string text)
        {
            Regex pattern = new Regex(@"^([0-9]{0,10})$");
            return pattern.IsMatch(text);
        }

        public static bool isChar(string text)
        {
            Regex pattern = new Regex(@"^([A-Za-z]{0,20})$");
            return pattern.IsMatch(text);
        }
    }
}
