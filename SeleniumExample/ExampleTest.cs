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
            using (var app = AppUnderTest.Start())
            {
                var element = app.FindElements(By.TagName("h2"));
                element.Should().HaveCount(3);
            }
        }
    }
}
