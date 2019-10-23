using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using sep2019.Utilities;
using System;

namespace sep2019.Page
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    class TimenMaterialTests
    {
        //IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            /*Easy Option For Sauce Authentication:
            *You can hardcode the values like this example below, but the best practice is to use environment variables
            */
            var sauceUserName = "KumarNZ1";
            var sauceAccessKey = "5b9dfb42-698d-4897-80fb-98b2d7cafe87";

            /*
             * In this section, we will configure our test to run on some specific
             * browser/os combination in Sauce Labs
             */
            var capabilities = new DesiredCapabilities();
            //set your user name and access key to run tests in Sauce
            capabilities.SetCapability("username", sauceUserName);
            //set your sauce labs access key
            capabilities.SetCapability("accessKey", sauceAccessKey);
            //set browser to Safari
            capabilities.SetCapability("browserName", "Safari");
            //set operating system to macOS version 10.13
            capabilities.SetCapability("platform", "macOS 10.13");
            //set the browser version to 11.1
            capabilities.SetCapability("version", "11.1");
            //set your test case name so that it shows up in Sauce Labs
            capabilities.SetCapability("name", TestContext.CurrentContext.Test.Name);

            //create a new Remote driver that will allow your test to send
            //commands to the Sauce Labs grid so that Sauce can execute your tests
            GlobalDriver.driver = new RemoteWebDriver(new Uri("http://ondemand.saucelabs.com:80/wd/hub"),
                capabilities, TimeSpan.FromSeconds(600));

            //navigate to turn up application
            GlobalDriver.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //TC1 - Create and verify the time n material
            //Login 
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSuccess(GlobalDriver.driver);
        }


        [TearDown]
        public void AfterEachTest()
        {

            GlobalDriver.driver.Quit();
        }

        [Test]
        [Category("Regression")]
        [Category("Sanity")]
        public void CreatenValidateTests()
        {

            //Home page
            HomePage home = new HomePage();
            home.ClickAdminstration(GlobalDriver.driver);
            home.ClickTimenMaterial(GlobalDriver.driver);

            // Time n Material page
            TimeMaterialPage timeMaterial = new TimeMaterialPage();
            //timeMaterial.ClickCreateNewBtn();

            ////Create Time n Material Page
            //TimeMaterialCreatePage timeMaterialCreate = new TimeMaterialCreatePage(driver);
            //timeMaterialCreate.FillInValidDetails();
            //timeMaterialCreate.ClickSave();

            //validation
            timeMaterial.ValidateRecord(GlobalDriver.driver);


        }

        [Test]
        [Category("Regression")]

        [Category("Sanity")]
        public void EditNValidate()
        {
            //Home page
            HomePage home = new HomePage();
            home.ClickAdminstration(GlobalDriver.driver);
            home.ClickTimenMaterial(GlobalDriver.driver);
        }


        [Test]
        [Category("Regression")]
        public void DeletenValidate()
        {
            //Home page
            HomePage home = new HomePage();
            home.ClickAdminstration(GlobalDriver.driver);
            home.ClickTimenMaterial(GlobalDriver.driver);
        }
    }
}
