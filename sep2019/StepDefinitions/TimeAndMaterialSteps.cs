using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace sep2019.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialSteps
    {
        IWebDriver driver;

        [Given(@"I have logged in to Turn Up portal")]
        public void GivenIHaveLoggedInToTurnUpPortal()
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

        [Given(@"I have Navigated to Time and Material page")]
        public void GivenIHaveNavigatedToTimeAndMaterialPage()
        {
            //Home page
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
        }

        [Then(@"I should be able to create a time record successfully")]
        public void ThenIShouldBeAbleToCreateATimeRecordSuccessfully()
        {
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
    }
}
