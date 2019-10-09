using OpenQA.Selenium;
using sep2019.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep2019
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement username => driver.FindElement(By.Id("UserName"));
        IWebElement password => driver.FindElement(By.Id("Password"));
        IWebElement loginBtn => driver.FindElement(By.XPath("//input[@value='Log in']"));
        
        internal void LoginSuccess()
        {
            //type the user name as hari
            username.SendKeys("hari");

            // identify and type the password as 123123
            password.SendKeys("123123");

            Async.WaitForWebElementClickable(driver, "//input[@value='Log in']", 1, "XPath");

            //click on login button 
            loginBtn.Click();
        }
        internal void LoginFailure()
        {

            //type the user name as hari
            username.SendKeys("34234");
            password.SendKeys("324234");
            loginBtn.Click();

            //verfying that login is failed
        }
    }
}
