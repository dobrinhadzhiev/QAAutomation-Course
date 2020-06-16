using NUnit.Framework;
using HomeWorkBestPractices.Pages.Exercise_1_GoogleSearchPages.GoogleHome;
using HomeWorkBestPractices.Pages.Exercise_1_GoogleSearchPages.GoogleSearchResults;
using HomeWorkBestPractices.Pages.Exercise_1_GoogleSearchPages.SeleniumPage;

namespace HomeWorkBestPractices.Tests.Exercise_1_GoogleSearchTests
{

    [TestFixture]

    class GoogleSearchTest : BaseTest
    {
        private GoogleHome _googleHomePage;
        private GoogleSearchResults _googleResultsPage;
        private SeleniumPage _seleniumPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();          
            _googleHomePage = new GoogleHome(Driver);
            _googleResultsPage = new GoogleSearchResults(Driver);
            _seleniumPage = new SeleniumPage(Driver);
            _googleHomePage.NavigateTo();
        }

        // Exercise1 a - Find the first search result for "selenium" in Google and assert the URL of the displayed page
        [Test]
        public void Exercise1_GoogleSearch_AssertURL()
        {

            _googleHomePage.GoogleSearch("selenium");


            _googleResultsPage.ClickOnFirstResult();


            _seleniumPage.AssertPageURL("https://www.selenium.dev/");
                        
        }


        // Exercise1 a - Find the first search result for "selenium" in Google and assert the title of the displayed page
        [Test]
        public void Exercise1_GoogleSearch_AssertTitle()

        {
            _googleHomePage.GoogleSearch("selenium");


            _googleResultsPage.ClickOnFirstResult();


            _seleniumPage.AssertPageTitle("SeleniumHQ Browser Automation");

        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
