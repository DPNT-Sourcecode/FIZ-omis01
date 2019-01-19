using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    public class FizzBuzzSolutionTest
    {
        [TestCase(3, ExpectedResult = "fizz fake deluxe")]
        public string TestFizzOne(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(6, ExpectedResult = "fizz")]
        public string TestFizzTwo(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(13, ExpectedResult = "fizz")]
        public string TestFizzThree(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(5, ExpectedResult = "buzz fake deluxe")]
        public string TestBuzzOne(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(10, ExpectedResult = "buzz")]
        public string TestBuzzTwo(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(15, ExpectedResult = "fizz buzz fake deluxe")]
        public string TestFizzBuzz(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(16, ExpectedResult = "16")]
        public string TestNotFizzNotBuzz(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(36, ExpectedResult = "fizz deluxe")]
        public string TestFizzDeluxeOne(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(396, ExpectedResult = "fizz deluxe")]
        public string TestFizzDeluxeTwo(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(936, ExpectedResult = "fizz deluxe")]
        public string TestFizzDeluxeThree(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }
    }
}

