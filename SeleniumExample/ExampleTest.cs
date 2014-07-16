using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void Pressing_AboutMenuItem_Should_Open_AboutPage()
        {
            using (var app = App.Start())
            {
                app.MainForm().AboutMenuitem().Click();

                app.Title.Should().Contain("About");
            }
        }

        [TestMethod]
        public void Pressing_RegisterMenuItem_Should_Open_RegisterPage()
        {
            using (var app = App.Start())
            {
                app.MainForm().RegisterMenuitem().Click();

                app.Title.Should().Contain("Register");
            }
        }

        [TestMethod]
        public void Clicking_RequestInfo_On_ContactPage_Should_Open_SendInfoPage()
        {
            using (var app = App.Start())
            {
                var contactPage = app.MainForm().OpenContactPage();
                contactPage.RequestInfoLink.Click();

                app.Title.Should().Contain("Request more info");
            }
        }

        [TestMethod]       
        public void Submitting_RequestInfoPage_Without_Name_Should_Give_ValidationError()
        {
            using (var app = App.Start())
            {
                var requestInfoPage = app.MainForm().OpenContactPage().OpenRequestInfoPage();
                requestInfoPage.Name = "";
                requestInfoPage.EmailAddress = "test@test.com";
                requestInfoPage.Submit();
                requestInfoPage.ValidationMessageFor("Name").Should().Be("Your name is required");
            }
        }

        [TestMethod]
        public void Submitting_RequestInfoPage_Without_EmailAddress_Should_Give_ValidationError()
        {
            using (var app = App.Start())
            {
                var requestInfoPage = app.MainForm().OpenContactPage().OpenRequestInfoPage();
                requestInfoPage.Name = "valid name";
                requestInfoPage.EmailAddress = "";
                requestInfoPage.Submit();
                requestInfoPage.ValidationMessageFor("EmailAddress").Should().Be("A valid emailaddress is required");
            }
        }

        [TestMethod]
        public void Submitting_RequestInfoPage_With_Invalid_EmailAddress_Should_Give_ValidationError()
        {
            using (var app = App.Start())
            {
                var requestInfoPage = app.MainForm().OpenContactPage().OpenRequestInfoPage();
                requestInfoPage.Name = "valid name";
                requestInfoPage.EmailAddress = "this is not a valid email address";
                requestInfoPage.Submit();
                requestInfoPage.ValidationMessageFor("EmailAddress").Should().Be("A valid emailaddress is required");
            }
        }

        [TestMethod]
        public void Submitting_RequestInfoPage_With_Name_And_Valid_EmailAddress_Should_OpenConfirmationPage()
        {
            using (var app = App.Start())
            {
                var requestInfoPage = app.MainForm().OpenContactPage().OpenRequestInfoPage();
                requestInfoPage.Name = "valid name";
                requestInfoPage.EmailAddress = "test@test.com";
                requestInfoPage.Submit();
                app.Title.Should().Contain("Confirmation");
            }
        }

    }
}
