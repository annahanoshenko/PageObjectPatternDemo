using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjPatternDemo.ProcessCreationPOM._003
{
    internal class MainPage
    {
        private IWebDriver Driver;


        public MainPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void CheckThatAlertMessageContainsText(string message)
        {
            Assert.That(Driver.FindElement(By.CssSelector(".alert-success")).Text.Contains(message));
        }

        public void LoginWithNameAndPassword(string name, string pwd)
        {
            Driver.FindElement(By.LinkText("Sign In")).Click();
            Driver.FindElement(By.Name("email")).Click();
            Driver.FindElement(By.Name("email")).Clear();
            Driver.FindElement(By.Name("email")).SendKeys("user@email.com");
            Driver.FindElement(By.Name("password")).Click();
            Driver.FindElement(By.Name("password")).Clear();
            Driver.FindElement(By.Name("password")).SendKeys("demo");
            Driver.FindElement(By.Name("login")).Click();
        }
    }
}
