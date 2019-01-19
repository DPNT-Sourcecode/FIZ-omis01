using BeFaster.App.Solutions.HLO;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionTest
    {
        private const string testMessage = "Hello, World!";

        [TestCase(testMessage, ExpectedResult = testMessage)]
        public string TestMessage(string message)
        {
            return HelloSolution.Hello(message);
        }

        [TestCase("John", ExpectedResult = "Hello, John!")]
        public string TestMessageTwo(string name)
        {
            return HelloSolution.HelloTwo(name);
        }
    }
}
