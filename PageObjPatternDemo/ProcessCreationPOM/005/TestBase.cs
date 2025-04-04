﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjPatternDemo.ProcessCreationPOM._005
{
    internal class TestBase
    {
        public IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demo.litecart.net/");

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
