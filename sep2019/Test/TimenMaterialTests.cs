using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace sep2019.Page
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    class TimenMaterialTests
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            // instance of browser 
            driver = new ChromeDriver();

            //navigate to turn up application
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //TC1 - Create and verify the time n material
            //Login 
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
        }


        [TearDown]
        public void AfterEachTest()
        {
            driver.Quit();
        }

        [Test]
        [Category("Regression")]
        [Category("Sanity")]
        public void CreatenValidateTests()
        {

            //Home page
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();

            // Time n Material page
            TimeMaterialPage timeMaterial = new TimeMaterialPage(driver);
            //timeMaterial.ClickCreateNewBtn();

            ////Create Time n Material Page
            //TimeMaterialCreatePage timeMaterialCreate = new TimeMaterialCreatePage(driver);
            //timeMaterialCreate.FillInValidDetails();
            //timeMaterialCreate.ClickSave();

            //validation
            timeMaterial.ValidateRecord();


        }

        [Test]
        [Category("Regression")]

        [Category("Sanity")]
        public void EditNValidate()
        {
            //Home page
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
        }


        [Test]
        [Category("Regression")]
        public void DeletenValidate()
        {
            //Home page
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
        }
    }
}
