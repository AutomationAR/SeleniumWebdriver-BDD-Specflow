using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assessment_Aautomation_Test.Drivers
{
    public class Seleniumdriver
    {
        private IWebDriver driver;
        private readonly ScenarioContext scenariocontext;

        public Seleniumdriver()
        {
            // Initialize WebDriver (assuming Chrome in this example)
            ChromeOptions options = new ChromeOptions();
            // Add any desired Chrome options here
            driver = new ChromeDriver(options);
        }

        public IWebDriver setup()
        {
            // Set up Chrome options
            ChromeOptions options = new ChromeOptions();
            // Add any desired Chrome options here

            // Initialize ChromeDriver
            driver = new ChromeDriver(options);

            // Return the WebDriver instance
            return driver;
        }
    }
}
