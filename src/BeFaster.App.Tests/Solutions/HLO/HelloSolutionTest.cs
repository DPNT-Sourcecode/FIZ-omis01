using BeFaster.App.Solutions.HLO;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionTest
    {
        [TestCase("John", ExpectedResult = "Hello, John!")]
        public string TestMessageTwo(string name)
        {
            return HelloSolution.Hello(name);
        }
    }
}