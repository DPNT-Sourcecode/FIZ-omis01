using BeFaster.Runner.Exceptions;
using System;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {        
        public static string FizzBuzz(int number)
        {
            var result = string.Empty;
            var numberAsString = number.ToString();

            if (number % 3 == 0 || numberAsString.Contains("3"))
            {
                result = "fizz";

                if (number % 5 == 0 || numberAsString.Contains("5"))
                {
                    result += " buzz";

                    result = ApplyDeluxeRule(number, numberAsString, result);
                }
                else
                {
                    result = ApplyDeluxeRule(number, numberAsString, result);
                }
            }
            else if (number % 5 == 0 || numberAsString.Contains("5"))
            {
                result = "buzz";

                result = ApplyDeluxeRule(number, numberAsString, result);
            }
            else
            {
                result = ApplyDeluxeRule(number, numberAsString, result);

                if (result == string.Empty)
                {
                    result = number.ToString();
                }
            }

            return result;
        }

        private static bool AllDigitsTheSame(string testString)
        {
            var result = true;

            var firstDigit = Convert.ToChar(testString.Substring(0, 1));

            foreach(var check in testString)
            {
                if (check != firstDigit)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static string ApplyDeluxeRule(
                                                int number,
                                                string numberAsString,
                                                string suppliedResult)
        {
            var result = string.Empty;

            if (number > 10 && AllDigitsTheSame(numberAsString))
            {
                if (number % 2 != 0)
                {
                    result = " fake deluxe";
                }
                else
                {
                    result = " deluxe";
                }
            }

            return suppliedResult + result;
        }
    }
}


