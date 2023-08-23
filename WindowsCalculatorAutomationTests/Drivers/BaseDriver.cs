using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;

namespace WindowsCalculatorAutomationTests.Drivers
{
    public class BaseDriver
    {
        public const string AppiumServer = "http://127.0.0.1:4723";
        public const string AppLocation = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
        public WindowsDriver<WindowsElement> driver;
        public AppiumOptions appiumOptions;

        [OneTimeSetUp]
        public void SetUp()
        {
            appiumOptions = new AppiumOptions();

            appiumOptions.AddAdditionalCapability("app", AppLocation);
            appiumOptions.AddAdditionalCapability("PlatformName", "Windows");
            appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");

            this.driver = new WindowsDriver<WindowsElement>(new Uri(AppiumServer), appiumOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.CloseApp();
            driver.Quit();
        }
    }
}
