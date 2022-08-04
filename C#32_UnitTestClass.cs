using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using GoogleSearchTest.POM;

namespace GoogleSearchTest
{
    public class Tests
    {
        private IWebDriver driver = new ChromeDriver(@"C:\chromedriver");

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Test started");
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
        }
        [TestCase("It Craft")]
        [TestCase("Microsoft")]
        public void Test1(string value)
        {
            MainPage main = new MainPage(driver);
            main.goToPage();
            ResultPage resultPage = main.goToResultPage(value);
            //04.08.2022_start
            IWebElement NumberOfresults = resultPage.GetNumberOfresults();
            IWebElement RequestTime = resultPage.GetRequestTime();
            string _numberOfResults = NumberOfresults.Text.Replace(RequestTime.Text, "");
            double _results;
            double.TryParse(string.Join("", _numberOfResults.Where(c => char.IsDigit(c))), out _results);
            Assert.That(_results, Is.GreaterThan(100));
            //04.08.2022_end
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Close();
        }
    }
}