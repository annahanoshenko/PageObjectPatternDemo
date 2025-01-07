using OpenQA.Selenium;

namespace PageObjPatternDemo.ProcessCreationPOM._006.Pages
{
    public class MainPage : BasePage
    {
        private IWebElement SignButton => Driver.FindElement(By.LinkText("Sign In"));
        private IWebElement EmailTextField => Driver.FindElement(By.Name("email"));
        private IWebElement PasswordTextField => Driver.FindElement(By.Name("password"));
        private IWebElement LoginButton => Driver.FindElement(By.Name("login"));
        private IWebElement AlertMessage => Driver.FindElement(By.CssSelector("#main .alert"));

        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public void CheckThatAlertMessageContainsText(string message)
        {
            string alertText = AlertMessage.Text;
            Assert.That(alertText.Contains(message));
        }

        public MainPage LoginWithNameAndPassword(string name, string pwd)
        {
            SignButton.Click();

            EmailTextField.Click();
            EmailTextField.Clear();
            EmailTextField.SendKeys(name);

            PasswordTextField.Click();
            PasswordTextField.Clear();
            PasswordTextField.SendKeys(pwd);

            LoginButton.Click();

            return this;
        }
    }
}
