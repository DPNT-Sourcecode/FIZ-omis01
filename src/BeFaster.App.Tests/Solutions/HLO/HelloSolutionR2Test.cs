using BeFaster.App.Solutions.HLO;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionR2Test
    {
        private const string testMessage = "Hello, {0}!";

        [TestCase(testMessage, ExpectedResult = testMessage)]
        public string TestMessage(string message)
        {
            return HelloSolution
        }
    }
}
