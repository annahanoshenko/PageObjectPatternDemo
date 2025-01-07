using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjPatternDemo.ProcessCreationPOM._004.Base
{
    internal class PageBase
    {
        public IWebDriver Driver;

        public PageBase(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement Element(By by)
        {
            return Driver.FindElement(by);
        }
        public void Click(By by)
        {
            Element(by).Click();
        }

        public void Clear(By by)
        {
            Element(by).Clear();
        }

        public void SendKeys(By by, string text)
        {
            Element(by).SendKeys(text);
        }

        public string GetText(By by)
        {
            return Element(by).Text;
        }

    }
}
