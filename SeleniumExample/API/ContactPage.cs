using OpenQA.Selenium;

namespace Selenium.Example.API
{
    public class ContactPage
    {
        internal readonly IWebDriver webdriver;
        public ContactPage(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }

        public IWebElement RequestInfoLink
        {
            get
            {
                return webdriver.FindElement(By.LinkText("Request Info"));
            }
        }

        public RequestInfoPage OpenRequestInfoPage()
        {
            RequestInfoLink.Click();
            return new RequestInfoPage(webdriver);
        }
    }
}
