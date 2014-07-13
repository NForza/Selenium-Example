using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    public static class IWebDriverExtensions
    {
        public static MainPage MainForm(this IWebDriver webDriver)
        {
            return new MainPage(webDriver);
        }
    }
}
