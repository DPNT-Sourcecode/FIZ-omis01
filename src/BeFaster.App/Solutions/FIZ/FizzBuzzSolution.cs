using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var result = string.Empty;

            if (number % 3 == 0)
            {
                if (number % 5 == 0)
                {
                    result = "fizz buzz";
                }
                else
                {
                    result = "fizz";
                }
            }
            else if (number % 5 == 0)
            {
                result = "buzz";
            }
            else
            {
                result = number.ToString();
            }

            return result;
        }
    }
}

