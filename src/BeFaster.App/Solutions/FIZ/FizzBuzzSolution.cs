using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var result = string.Empty;

            switch (number)
            {
                case 3:
                    result = "fizz";
                default:

            }

            return result;
        }
    }
}
