﻿using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    public class FizzBuzzSolutionTest
    {
        [TestCase(3, ExpectedResult = "fizz")]
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

        [TestCase(5, ExpectedResult = "buzz")]
        public string TestBuzzOne(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(10, ExpectedResult = "buzz")]
        public string TestBuzzTwo(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(15, ExpectedResult = "fizz buzz")]
        public string TestFizzBuzz(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(16, ExpectedResult = "16")]
        public string TestNotFizzNotBuzz(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(11, ExpectedResult = "fake deluxe")]
        public string TestDeluxe(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(33, ExpectedResult = "fizz fake deluxe")]
        public string TestFizzDeluxeOne(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(222, ExpectedResult = "fizz deluxe")]
        public string TestFizzDeluxeTwo(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }

        [TestCase(777, ExpectedResult = "fizz fake deluxe")]
        public string TestFizzDeluxeThree(int suppliedNumber)
        {
            return FizzBuzzSolution.FizzBuzz(suppliedNumber);
        }
    }
}