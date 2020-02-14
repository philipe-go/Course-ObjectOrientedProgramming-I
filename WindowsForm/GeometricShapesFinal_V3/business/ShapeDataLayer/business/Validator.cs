using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ShapesDataLayer.business
{
    //3.0
    public class Validator
    {
        public static bool isDecimal(string text)
        {
            Regex pattern = new Regex(@"^([0-9]+[.]?[0-9]*)$");
            return pattern.IsMatch(text);
        }

        public static bool isDigit(string text)
        {
            Regex pattern = new Regex(@"^([0-9]+)$");
            return pattern.IsMatch(text);
        }
    }
}
