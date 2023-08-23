using OpenQA.Selenium.Appium.Windows;
namespace WindowsCalculatorAutomationTests.Views.StandardCalculatorView
{
    public partial class StandardCalculatorView
    {
        private readonly WindowsDriver<WindowsElement> driver;
        public StandardCalculatorView(WindowsDriver<WindowsElement> driver) => this.driver = driver;


        public string SumTwoNumbers(int firstValue, int secondValue)
        {
            var firstNumber = driver.FindElementByName(GetNumber(firstValue));
            var secondnumber = driver.FindElementByName(GetNumber(secondValue));

            clearButton.Click();
            firstNumber.Click();
            plusButton.Click();
            secondnumber.Click();
            equalsButton.Click();

            return resultField.Text;
        }

        public string GetNumber(int number)
        {
            switch (number)
            {
                case 0:
                    return "Zero";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                default:
                    throw new NotSupportedException($"Invalid number = {number}");
            }
        }
    }
}
