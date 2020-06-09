using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;

namespace SurveyCorona.pom
{
    class SecondPage
    {
        //[FindsBy(How = How.Id, Using = "survey-submit")]
        //private IWebElement BtnSubmit { get; set; }

        //public SecondPage(IWebDriver driver)
        //{
        //    PageFactory.InitElements(driver, this);
        //}

        private readonly RemoteWebDriver _driver;

        public SecondPage(RemoteWebDriver driver) => _driver = driver;

        private IWebElement BtnSubmit => _driver.FindElementById("survey-submit");

        public void ClickBtnSubmit()
        {
            BtnSubmit.Click();
        }

    }
}
