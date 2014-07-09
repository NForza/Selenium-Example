using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://www.nu.nl");
                var element = driver.FindElement(By.Id("header"));
                element.GetAttribute("class").Should().Contain("searchOptions");
            }
        }
    }
}
