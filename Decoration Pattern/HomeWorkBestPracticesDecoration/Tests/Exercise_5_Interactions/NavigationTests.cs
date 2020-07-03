using HomeWorkBestPractices.Pages.Exercise_5_Interactions.DemoQAHomePage;
using HomeWorkBestPractices.Pages.Exercise_5_Interactions.DemoQAMainPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.IO;
using OpenQA.Selenium;

namespace HomeWorkBestPractices.Tests.Exercise_5_Interactions
{
    class NavigationTests : BaseTest
    {
        private DemoQAHomePage _demoQAHomePage;
        private DemoQAMainPage _demoQAMainPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _demoQAHomePage = new DemoQAHomePage(Driver);
            _demoQAHomePage.NavigateTo();
            _demoQAMainPage = new DemoQAMainPage(Driver);
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void AssertHeaderText_WhenSelectingDifferentOptions(string option)
        {
            _demoQAHomePage.CategoryOption("Interactions").Click();
                        
            _demoQAMainPage.OptionsPanel.ScrollToElement();
            _demoQAMainPage.SubMenu(option).Click();
            

            Assert.AreEqual(option, _demoQAMainPage.PageHeader.Text);

        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver.WrappedDriver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\ScreenShots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);

            }

            Driver.Quit();
        }
    }
}
