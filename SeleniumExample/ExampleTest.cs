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

        [TestMethod]
        public void Pressing_AboutMenuItem_Should_Open_AboutPage()
        {
            using (var app = AppUnderTest.Start())
            {
                app.MainForm().AboutMenuitem().Click();

                app.Title.Should().Contain("About");
            }
        }

        [TestMethod]
        public void Pressing_RegisterMenuItem_Should_Open_RegisterPage()
        {
            using (var app = AppUnderTest.Start())
            {
                app.MainForm().RegisterMenuitem().Click();

                app.Title.Should().Contain("Register");
            }
        }

        [TestMethod]
        public void Clicking_RequestInfo_On_ContactPage_Should_Open_SendInfoPage()
        {
            using (var app = AppUnderTest.Start())
            {
                var contactPage = app.MainForm().OpenContactPage();
                contactPage.RequestInfoLink.Click();

                app.Title.Should().Contain("Request more info");
            }
        }
    }
}
