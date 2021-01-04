using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SurveyCorona.pom;
using static SurveyCorona.constants.HebrewEnglish;

namespace SurveyCorona.tests.scenarious
{
    public class SampleTests : TestBase
    {
        protected void SendSurvey()
        {
            webDriver.Url = URL_CORONA;

            FirstPage firstPage = new FirstPage(webDriver);

            firstPage.EnterFirstName(IGOR);
            firstPage.EnterLastName(GINDIN);
            firstPage.CheckAgree();
            firstPage.EnterEmail(MY_EMAIL);

            firstPage.ClickBtnNext();


            SecondPage secondPage = new SecondPage(webDriver);

            Assert.IsTrue(secondPage.PageContains(IGOR));
            Assert.IsTrue(secondPage.PageContains(GINDIN));
            Assert.IsTrue(secondPage.PageContains(MY_EMAIL));

        }
    }
}
