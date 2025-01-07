using OpenQA.Selenium;

namespace PageObjPatternDemo.ProcessCreationPOM._006.Pages
{
    public class MainPageV2 : BasePage
    {
        private readonly By signIn = By.LinkText("Sign In");
        private readonly By email = By.Name("email");
        private readonly By password = By.Name("password");
        private readonly By login = By.Name("login");
        private readonly By alert = By.CssSelector("#main .alert");

        private IWebElement SignButton => Driver.FindElement(signIn);
        private IWebElement EmailTextField => Driver.FindElement(email);
        private IWebElement PasswordTextField => Driver.FindElement(password);
        private IWebElement LoginButton => Driver.FindElement(login);
        private IWebElement AlertMessage => Driver.FindElement(alert);

        public MainPageV2(IWebDriver driver) : base(driver)
        {
        }

        public void CheckThatAlertMessageContainsText(string message)
        {
            string alertText = AlertMessage.Text;
            Assert.That(alertText.Contains(message));
        }

        public MainPageV2 LoginWithNameAndPassword(string name, string pwd)
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
