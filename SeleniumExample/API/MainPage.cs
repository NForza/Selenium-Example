using OpenQA.Selenium;

namespace Selenium.Example.API
{
    public class MainPage
    {
        private readonly IWebDriver webdriver;
        public MainPage(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }

        public IWebElement AboutMenuitem()
        {
            return webdriver.FindElement(By.LinkText("About"));
        }

        public IWebElement RegisterMenuitem()
        {
            return webdriver.FindElement(By.LinkText("Register"));
        }

        public IWebElement ContactMenuitem()
        {
            return webdriver.FindElement(By.LinkText("Contact"));
        }

        public ContactPage OpenContactPage()
        {
            webdriver.FindElement(By.LinkText("Contact")).Click();

            return new ContactPage(webdriver);
        }

    }
}
