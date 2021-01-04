using NUnit.Framework;
using SurveyCorona.tests.scenarious;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SurveyCorona.tests
{
    [TestFixture]
    public class ChromeSampleTests : SampleTests
    {

        [SetUp]
        public void SetUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void TestSendSurvey()
        {
            SendSurvey();
        }

        [TearDown]
        public void TearDown()
        {
            if (webDriver != null)
                webDriver.Quit();
        }
    }
}
