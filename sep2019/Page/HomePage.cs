using OpenQA.Selenium;
using sep2019.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sep2019
{
    class HomePage
    {
        //private IWebDriver drv;
        //public HomePage(IWebDriver driver )
        //{
        //    this.drv = driver;

        //}

        internal void ClickAdminstration(IWebDriver driver)
        {
            //Implicit wait
            Thread.Sleep(5000);

            //Explicit wait
            Async.WaitForWebElementVisiblity(driver, "//a[@href='#'][contains(.,'Administration')]", 3, "XPath");

            IWebElement AdminLink = driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]"));
            AdminLink.Click();
        }

        internal void ClickTimenMaterial(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();

        }
    }
}
