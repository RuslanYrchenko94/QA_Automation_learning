using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace GoogleSearchTest.POM
{
    internal class MainPage
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.TagName, Using = "input")]
        private IWebElement searchField;

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        public ResultPage goToResultPage(string searchWord)
        {
            searchField.SendKeys(searchWord);
            searchField.SendKeys(Keys.Enter);
            return new ResultPage(driver);
        }
    }
}