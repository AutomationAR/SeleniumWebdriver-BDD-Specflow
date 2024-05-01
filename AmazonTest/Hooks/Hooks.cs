using Assessment_Aautomation_Test.Drivers;

namespace Assessment_Aautomation_Test.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly ScenarioContext scenarioContext;
        public Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
            Seleniumdriver seleniumdriver = new Seleniumdriver();
            ScenarioContext.Current.Set(seleniumdriver, "Seleniumdriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {

            //TODO: implement logic that has to run after executing each scenario
            Console.WriteLine("Selenium webdriver quit");
            //var driver = ScenarioContext.Current.Get<IWebDriver>("WebDriver");


        }
    }
}