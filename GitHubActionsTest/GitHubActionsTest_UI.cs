global using NUnit.Framework;

namespace GitHubActionsTest_UI
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UI_Test()
        {
            Console.WriteLine("UI_Test is runnning.");
            Assert.Pass("UI_Test is executed.");
        }
    }
}