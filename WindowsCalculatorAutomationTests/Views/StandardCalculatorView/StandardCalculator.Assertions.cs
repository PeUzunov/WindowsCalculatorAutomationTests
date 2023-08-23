namespace WindowsCalculatorAutomationTests.Views.StandardCalculatorView
{
    public partial class StandardCalculatorView
    {
        public void VerifySumOfTheTwoNumbersIsCorrect(int firstValue, int secondValue, string expectedResult)
        {
            string actualResult = SumTwoNumbers(firstValue, secondValue);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
