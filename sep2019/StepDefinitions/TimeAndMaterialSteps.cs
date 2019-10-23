using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using sep2019.Utilities;
using System;
using TechTalk.SpecFlow;

namespace sep2019.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialSteps
    {
        //IWebDriver driver;

        [Given(@"I have logged in to Turn Up portal")]
        public void GivenIHaveLoggedInToTurnUpPortal()
        {
            // instance of browser 
            GlobalDriver.driver = new ChromeDriver();

            //navigate to turn up application
            GlobalDriver.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //TC1 - Create and verify the time n material
            //Login 
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSuccess(GlobalDriver.driver);
        }

        [Given(@"I have Navigated to Time and Material page")]
        public void GivenIHaveNavigatedToTimeAndMaterialPage()
        {
            //Home page
            HomePage home = new HomePage();
            home.ClickAdminstration(GlobalDriver.driver);
            home.ClickTimenMaterial(GlobalDriver.driver);
        }

        [Then(@"I should be able to create a time record successfully")]
        public void ThenIShouldBeAbleToCreateATimeRecordSuccessfully()
        {
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
    }
}
