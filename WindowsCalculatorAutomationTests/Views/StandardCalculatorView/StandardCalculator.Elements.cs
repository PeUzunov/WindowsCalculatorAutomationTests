using OpenQA.Selenium.Appium.Windows;

namespace WindowsCalculatorAutomationTests.Views.StandardCalculatorView
{
    public partial class StandardCalculatorView
    {
        public WindowsElement numberOneButton => driver.FindElementByName("One");
        public WindowsElement numberTwoButton => driver.FindElementByName("Two");
        public WindowsElement plusButton => driver.FindElementByName("Plus");
        public WindowsElement equalsButton => driver.FindElementByName("Equals");
        public WindowsElement clearButton => driver.FindElementByAccessibilityId("clearButton");
        public WindowsElement resultField => driver.FindElementByAccessibilityId("CalculatorResults");
    }
}
