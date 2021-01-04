using OpenQA.Selenium;
using System;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Remote;

namespace SurveyCorona.pom
{
    class FirstPage
    {

        [FindsBy(How = How.Id, Using = "edit-submitted-node7341-new-1585718015800")]
        public IWebElement InputFirstName { get; set; }
        [FindsBy(How = How.Id, Using = "edit-submitted-node7341-new-1585718049618")]
        public IWebElement InputLastName { get; set; }
        [FindsBy(How = How.Id, Using = "edit-submitted-node7341-cid-8-1")]
        public IWebElement CheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "edit-submitted-node7341-new-1585744214315")]
        public IWebElement InputEmail { get; set; }
        [FindsBy(How = How.Name, Using = "op")]
        public IWebElement BtnNext { get; set; }

        public FirstPage(RemoteWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void EnterFirstName(String firstName)
        {
            InputFirstName.SendKeys(firstName);
        }

        public void EnterLastName(String lastName)
        {
            InputLastName.SendKeys(lastName);
        }

        public void CheckAgree()
        {
            if (CheckBox.GetAttribute("aria-checked").Equals("false", StringComparison.OrdinalIgnoreCase))
            {
                CheckBox.Click();
            }
        }

        public void UncheckAgree()
        {
            if (CheckBox.GetAttribute("aria-checked").Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                CheckBox.Click();
            }
        }

        public void EnterEmail(String email)
        {
            InputEmail.SendKeys(email);
        }

        public void ClickBtnNext()
        {
            BtnNext.Click();
        }

    }
}
