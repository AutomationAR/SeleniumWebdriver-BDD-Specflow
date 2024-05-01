using Assessment_Aautomation_Test.Drivers;
using OpenQA.Selenium;

namespace Assessment_Aautomation_Test.StepDefinitions
{
    [Binding]
    public class CartValidationStepDefinitions
    {
        IWebDriver driver;
        private readonly ScenarioContext ScenarioContext;
        public CartValidationStepDefinitions(ScenarioContext ScenarioContext)
        {
            this.ScenarioContext = ScenarioContext;
        }
        [Given(@"navigate to amazon as an unregistered user")]
        public void GivenNavigateToAmazonAsAnUnregisteredUser()
        {
            driver = ScenarioContext.Get<Seleniumdriver>("Seleniumdriver").setup();
            driver.Url = "https://www.amazon.com/ ";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("div[class='a-text-center a-spacing-small a-size-mini']>a[href*='508088']")).Click();

        }

        [When(@"Search for TP-link")]
        public void WhenSearchForTP_Link(Table table)
        {
            driver.FindElement(By.XPath("//input[@id='twotabsearchtextbox']")).SendKeys(table.Rows[0]["Search item"]);
            driver.FindElement(By.XPath("//input[@id='nav-search-submit-button']")).Click();
        }

        [When(@"Add corresponding item to the cart")]
        public void WhenAddCorrespondingItemToTheCart()
        {
            driver.FindElement(By.XPath("//span[contains(text(), 'AX5400 WiFi 6 Router (Archer AX72 Pro) Multi Gigabit Wireless Internet Router, 1 x 2.5 Gbps Port, Dual Band, VPN Router')]")).Click();
            driver.FindElement(By.XPath("//input[@id='add-to-cart-button']")).Click();
        }

        [Then(@"Navigate to the cart and validate correct item and amount is displayed")]
        public void ThenNavigateToTheCartAndValidateCorrectItemAndAmountIsDisplayed(Table table)
        {
            var ProductPrice = table.Rows[0]["ProductPrice"];
            var ProductName = table.Rows[0]["ProductName"];
            driver.FindElement(By.XPath("//a[contains(text(),'Go to Cart')]")).Click();
            var productName = driver.FindElement(By.XPath("//span[contains(text(),'AX5400')]")).Text;
            var productPrice = driver.FindElement(By.CssSelector("span[id='sc-subtotal-amount-activecart']>span[class*='sc-white-space-nowrap']")).Text;
            AssertionOptions.ReferenceEquals(productName, ProductName);
            AssertionOptions.ReferenceEquals(productPrice, ProductPrice);
        }
    }
}
