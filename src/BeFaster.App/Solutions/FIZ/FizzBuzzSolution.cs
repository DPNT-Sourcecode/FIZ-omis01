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

            if (FizzTest(number, numberAsString))
            {
                result = "fizz";

                if (BuzzTest(number, numberAsString))
                {
                    result += " buzz";

                    result = ApplyDeluxeRule(number, numberAsString, result);
                }
                else
                {
                    result = ApplyDeluxeRule(number, numberAsString, result);
                }
            }
            else if (BuzzTest(number, numberAsString))
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

            foreach (var check in testString)
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
            var deluxeResult = string.Empty;

            if (number % 2 != 0)
            {
                deluxeResult = "fake deluxe";
            }
            else
            {
                deluxeResult = "deluxe";
            }

            if (suppliedResult != string.Empty && deluxeResult != string.Empty)
            {
                return suppliedResult + " " + deluxeResult;
            }

            return suppliedResult + deluxeResult;
        }

        private static bool BuzzTest(
                                                int number,
                                                string numberAsString)
        {
            if (number % 5 == 0 || numberAsString.Contains("5"))
            {
                return true;
            }

            return false;
        }

        private static bool FizzTest(
                                                int number,
                                                string numberAsString)
        {
            if (number % 3 == 0 || numberAsString.Contains("3"))
            {
                return true;
            }

            return false;
        }
    }
}

