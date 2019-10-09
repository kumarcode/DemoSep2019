using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep2019.Utilities
{
    class Async
    {
        //custom method to handle wait for a webelement to be visible
        public static void WaitForWebElementVisiblity(IWebDriver driver, string domValue, int seconds, string locator)
        {
            try
            {
                if (locator == "XPath")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(domValue)));
                }

                if (locator == "Id")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(domValue)));
                }

                if (locator == "ClassName")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(domValue)));
                }
            }
            catch(Exception msg)
            {
                Assert.Fail(msg.Message);
            }
            
        }


        //custom method to handle wait for a webelement to be clickable
        public static void WaitForWebElementClickable(IWebDriver driver, string domValue, int seconds, string locator)
        {
            try
            {
                if (locator == "XPath")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(domValue)));
                }

                if (locator == "Id")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(domValue)));
                }

                if (locator == "ClassName")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName(domValue)));
                }
            }
            catch (Exception msg)
            {
                Assert.Fail(msg.Message);
            }

        }
    }
}
