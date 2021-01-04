using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using SurveyCorona.pom;
using System;
using WebDriverManager.DriverConfigs.Impl;

using static SurveyCorona.constants.HebrewEnglish;

namespace SurveyCorona
{
    class Survey
    {
        private static RemoteWebDriver driver;

        static void Main(string[] args)
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = URL_CORONA;
            driver.Manage().Window.Maximize();

            Survey survey = new Survey();
            survey.FillFirstPage();
            survey.FinishSecondPage();

            if(driver != null)
            {
                driver.Quit();
            }

        }

        private void FillFirstPage()
        {
            FirstPage firstPage = new FirstPage(driver);

            firstPage.EnterFirstName(IGOR);
            firstPage.EnterLastName(GINDIN);
            firstPage.CheckAgree();
            firstPage.EnterEmail(MY_EMAIL);

            System.Threading.Thread.Sleep(1000);

            firstPage.ClickBtnNext();
        }

        private void FinishSecondPage()
        {
            //SecondPage secondPage = PageFactory.InitElements<SecondPage>(driver);
            SecondPage secondPage = new SecondPage(driver);

            System.Threading.Thread.Sleep(1000);

            secondPage.ClickBtnSubmit();
        }
    }
}
