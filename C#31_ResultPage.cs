using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace GoogleSearchTest.POM
{
    internal class ResultPage
    {
        private readonly IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "result-stats")]
        private IWebElement results;
        [FindsBy(How = How.CssSelector, Using = "#result-stats>nobr")]
        private IWebElement requestTime;

        public void ConsoleSearchData()
        {
            Console.WriteLine($"Number of results: {results.Text}, Request time {requestTime.Text}");
        }
    }
}