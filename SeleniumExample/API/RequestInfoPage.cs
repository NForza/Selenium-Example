using System;
using System.Runtime.CompilerServices;
using OpenQA.Selenium;

namespace Selenium.Example.API
{
    public class RequestInfoPage
    {
        private string _EmailAddress;
        private string _Name;
        private readonly IWebDriver webdriver;
        /// <summary>
        /// Initializes a new instance of the RequestInfoPage class.
        /// </summary>
        public RequestInfoPage(IWebDriver webdriver)
        {
            this.webdriver = webdriver;            
        }

        public void Submit()
        {
            webdriver.FindElement(By.XPath(@"//input[@type=""submit""]")).Click();
        }

        private void SetInputValue(string value, string type = "text", [CallerMemberName] string name = "")
        {
            webdriver.FindElement(                
                By.XPath(
                    string.Format(@"//input[@type=""{1}"" and @name=""{0}""]", name, type))).SendKeys(value);
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                SetInputValue(value);
            }
        }

        public string ValidationMessageFor(string propertyName)
        {
            try
            {
                var element = webdriver.FindElement(
                    By.XPath(
                        string.Format(
                            @"//span[@for=""{0}""]", propertyName)));
                return element.Text;
            }
            catch
            {
                return String.Empty;                
            }
        }

        public string EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                _EmailAddress = value;
                SetInputValue(value, "email");
            }
        }
    }
}
