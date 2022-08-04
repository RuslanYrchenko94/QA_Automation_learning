using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using GoogleSearchTest.POM;

namespace GoogleSearchTest
{
    public class Tests
    {	//04.08.2022_start
        private IWebDriver driver = new ChromeDriver(@"C:\chromedriver");
		//04.08.2022_end
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Test started");
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
        }
		//04.08.2022_start
        [TestCase("It Craft")]
        [TestCase("Microsoft")]
		//04.08.2022_end
        public void Test1(string value)
        {
            MainPage main = new MainPage(driver);
            main.goToPage();
            ResultPage resultPage = main.goToResultPage(value);
            resultPage.ConsoleSearchData();
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Close();
        }
    }
}