using WindowsCalculatorAutomationTests.Views.StandardCalculatorView;
using WindowsCalculatorAutomationTests.Drivers;

namespace WindowsCalculatorAutomationTests.Tests
{
    [TestFixture]
    public class StandardCalculatorTests : BaseDriver
    {
        private StandardCalculatorView standardCalculatorView;

        [SetUp]
        public void SetUpTests()
        {
            this.standardCalculatorView = new StandardCalculatorView(driver);
        }

        [TestCase(0, 1, "Display is 1")]
        [TestCase(1, 0, "Display is 1")]
        [TestCase(1, 2, "Display is 3")]
        [TestCase(9, 5, "Display is 14")]

        public void Test_SumPositiveWholeNumbers(int firstValue, int secondValue, string resultValue)
        {
            standardCalculatorView.VerifySumOfTheTwoNumbersIsCorrect(firstValue, secondValue, resultValue);
        }
    }
}
