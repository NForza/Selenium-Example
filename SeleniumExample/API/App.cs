using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.Example.API
{
    public class App
    {
        public static IWebDriver Start()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:61226/");
            return driver;
        }
    }
}
