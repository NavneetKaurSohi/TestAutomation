using System;
using OpenQA.Selenium;

namespace _2018_sep
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickAdministration()
        {
            IWebElement adminstration = driver.FindElement(By.XPath("//a[contains(.,'Administration ')]"));
            adminstration.Click();
        }

        internal void ClickTimenMaterial()
        {
            IWebElement timenMaterial = driver.FindElement(By.XPath("//a[contains(.,'Time & Materials')]"));
            timenMaterial.Click();
        }
    }
}