using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    public static class IWebDriverExtensions
    {
        public static IWebElement AboutMenuitem(this IWebDriver webDriver)
        {
            return webDriver.FindElement(By.LinkText("About"));
        }
    }
}
