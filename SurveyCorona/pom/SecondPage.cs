using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

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

        public bool PageContains(string text)
        {
            IWebElement body = _driver.FindElement(By.TagName("body"));
            return body.Text.Contains(text);
        }

    }
}
