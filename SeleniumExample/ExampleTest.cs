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
        public void Root_Should_Have_3_H2_headers()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:61226/");
                var element = driver.FindElements(By.TagName("h2"));
                element.Should().HaveCount(3);
            }
        }
    }
}
