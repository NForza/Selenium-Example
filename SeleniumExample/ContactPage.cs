using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    public class ContactPage
    {
        private readonly IWebDriver webdriver;
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
    }
}
