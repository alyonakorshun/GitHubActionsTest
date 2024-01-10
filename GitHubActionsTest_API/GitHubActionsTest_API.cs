global using NUnit.Framework;

namespace GitHubActionsTest_API
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void API_Test()
        {
            Console.WriteLine("API_Test is runnning.");
            Assert.Pass("API_Test is executed.");
        }
    }
}