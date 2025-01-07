using OpenQA.Selenium;

namespace PageObjPatternDemo.ProcessCreationPOM._006.Pages
{
    public class BasePage
    {
        public IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
