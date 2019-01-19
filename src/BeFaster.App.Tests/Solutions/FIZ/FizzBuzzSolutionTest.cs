using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    public class FizzBuzzSolutionTest
    {
        [TestCase(3, ExpectedResult = "fizz")]
        public string TestFizz(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }
    }
}

