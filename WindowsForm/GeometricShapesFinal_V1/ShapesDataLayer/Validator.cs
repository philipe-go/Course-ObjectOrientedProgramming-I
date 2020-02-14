using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace ShapesDataLayer
{
    //3.0
    class Validator
    {
        public static bool IsDigit(string input)
        {
            Regex pattern = new Regex(@"^([1-9]+)$");
            return pattern.IsMatch(input);
        }

        public static bool IsDecimal(string input)
        {
            Regex pattern = new Regex(@"^([1-9]+[.\,][0-9]+)$");
            return pattern.IsMatch(input);
        }

    }
}
