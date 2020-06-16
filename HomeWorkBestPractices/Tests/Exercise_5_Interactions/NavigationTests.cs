using HomeWorkBestPractices.Pages.Exercise_5_Interactions.DemoQAHomePage;
using HomeWorkBestPractices.Pages.Exercise_5_Interactions.DemoQAMainPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkBestPractices.Extensions;

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

            Driver.ScrollTo(_demoQAMainPage.OptionsPanel);
            _demoQAMainPage.SubMenu(option).Click();
            

            Assert.AreEqual(option, _demoQAMainPage.PageHeader.Text);

        }

        [TearDown]
        public void TearDown()
        {
           Driver.Quit();
        }
    }
}
