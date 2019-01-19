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
                if (number % 5 == 0 || numberAsString.Contains("5"))
                {
                    if (number > 10 && AllDigitsTheSame(numberAsString))
                    {
                        result = "fizz buzz deluxe";
                    }
                    else
                    {
                        result = "fizz buzz";
                    }
                }
                else if (number > 10 && AllDigitsTheSame(numberAsString))
                {
                    result = "fizz deluxe";
                }
                else
                {
                    result = "fizz";
                }
            }
            else if (number % 5 == 0 || numberAsString.Contains("5"))
            {
                if (number > 10 && AllDigitsTheSame(numberAsString))
                {
                    result = "buzz deluxe";
                }
                else
                {
                    result = "buzz";
                }
            }
            else if (number > 10 && AllDigitsTheSame(numberAsString))
            {
                result = "deluxe";
            }
            else
            {
                result = number.ToString();
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
    }
}
