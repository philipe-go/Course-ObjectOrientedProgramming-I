using System.Text.RegularExpressions;

namespace GeometricShapesApp.business
{
    public static class Validator
    {

        public static bool isDigit(string text)
        {
            Regex isdigit = new Regex(@"^[1-9]+[,\.]?[0-9]+)$");
            return isdigit.IsMatch(text);
        }

    }
}
