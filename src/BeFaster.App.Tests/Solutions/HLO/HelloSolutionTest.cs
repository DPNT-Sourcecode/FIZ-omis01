using BeFaster.App.Solutions.HLO;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionTest
    {
        private const string testMessage = "Hello to the world";
        [TestCase(testMessage, ExpectedResult = testMessage)]
        public string TestMessage(string message)
        {
            return HelloSolution.Hello(message);
        }
    }
}
