using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    public class MainForm
    {
        private readonly IWebDriver webdriver;
        public MainForm(IWebDriver webdriver)
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
    }

    public static class IWebDriverExtensions
    {
        public static MainForm MainForm(this IWebDriver webDriver)
        {
            return new MainForm(webDriver);
        }
    }
}
