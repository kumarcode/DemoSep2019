using System;
using OpenQA.Selenium;
using sep2019.Utilities;

namespace sep2019
{
    internal class TimeMaterialCreatePage
    {
        //private IWebDriver driver;

        //public TimeMaterialCreatePage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        internal void FillInValidDetails(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//input[@id='Code']")).SendKeys("qwerty");
            driver.FindElement(By.XPath("//input[@id='Description']")).SendKeys("asdfghgf");
            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("10");

        }

        internal void ClickSave(IWebDriver driver)
        {
            Async.WaitForWebElementVisiblity(driver, "//input[@id='SaveButton']", 5, "XPath");
            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();
        }
    }
}