using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.HLO
{
    public static class HelloSolution
    {
        public static string Hello(string friendName)
        {
            const string greeting = "Hello, {0}!";

            return string.Format(greeting, friendName);
        }
    }
}
