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

        //04.08.2022_start
        public IWebElement GetNumberOfresults()
        {
            return results;
        }
        public IWebElement GetRequestTime()
        {
            return requestTime;
        }
        //04.08.2022_end
    }
}