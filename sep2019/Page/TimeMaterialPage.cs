using System;
using OpenQA.Selenium;
using System.Threading;
using NUnit.Framework;

namespace sep2019
{
    internal class TimeMaterialPage
    {
        private IWebDriver driver;

        public void EditTM(IWebDriver driver)
        { }

        public void DeleteTM(IWebDriver driver)
        { }

        public TimeMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickCreateNewBtn()
        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']")).Click();
        }

        internal void ValidateRecord()
        {
            // implicit wait
            Thread.Sleep(3000);

            //TODO - Implement Explicit Wait
            try
            {
                while (true)
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                        Console.WriteLine(code.Text);

                        Assert.That(code.Text, Is.EqualTo("abc"));

                        //if (code.Text == "abc")
                        //{
                        //    Console.WriteLine("Test Success");
                        //    return;
                        //}
                    }
                    driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test failed");
            }
        }
    }
}