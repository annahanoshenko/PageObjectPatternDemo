using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjPatternDemo.ProcessCreationPOM._002
{
    internal class LiteCartTesting2
    {
        [TestFixture]
        public class LoginExampleTest2
        {
            private IWebDriver driver;

            [SetUp]
            public void Setup()
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://demo.litecart.net/");
            }

            [TearDown]
            public void TearDown()
            {
                driver.Close();
            }

            [Test]
            public void WhenLoginWithValidNameAndPassword_SuccessMessageShouldAppear()
            {
                LoginWithNameAndPassword("user@email.com", "demo");
                CheckThatAlertMessageContainsText("logged in as John Doe.");

            }
            public void CheckThatAlertMessageContainsText(string message)
            {
                Assert.That(driver.FindElement(By.CssSelector(".alert-success")).Text.Contains(message));
            }

            public void LoginWithNameAndPassword(string name, string pwd)
            {
                driver.FindElement(By.LinkText("Sign In")).Click();
                driver.FindElement(By.Name("email")).Click();
                driver.FindElement(By.Name("email")).Clear();
                driver.FindElement(By.Name("email")).SendKeys("user@email.com");
                driver.FindElement(By.Name("password")).Click();
                driver.FindElement(By.Name("password")).Clear();
                driver.FindElement(By.Name("password")).SendKeys("demo");
                driver.FindElement(By.Name("login")).Click();
               
            }
        }
    }
}
