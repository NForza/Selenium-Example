using OpenQA.Selenium;

namespace Selenium.Example.API
{
    public static class WebDriverExtensions
    {
        public static MainPage MainForm(this IWebDriver webDriver)
        {
            return new MainPage(webDriver);
        }
    }
}
