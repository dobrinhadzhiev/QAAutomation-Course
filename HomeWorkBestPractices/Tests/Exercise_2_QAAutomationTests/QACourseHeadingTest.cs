using NUnit.Framework;
using HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.NavigationBar;
using HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.QACoursePage;
using HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.Homepage;
using HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.QAAutomationModulePage;

namespace HomeWorkBestPractices.Tests.Exercise_2_QAAutomationTests
{
    [TestFixture]

    class QACourseHeadingTest : BaseTest
    {
        private SoftUniHomePage _softUniHomePage;
        private NavigationBar _homepageNavigationBar;
        private QAAutomationModulePage _qaAutomationModulePage;
        private QACoursePage _qaCousePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();            
            _softUniHomePage = new SoftUniHomePage(Driver);
            _homepageNavigationBar = new NavigationBar(Driver);
            _qaAutomationModulePage = new QAAutomationModulePage(Driver);
            _qaCousePage = new QACoursePage(Driver);
            _softUniHomePage.NavigateTo();

        }

        // Exercise2 - Navigate to Softuni -> QA Automation May 2020 and assert that there is a heading h1 and its text is "QA Automation - май 2020"

        [Test]
        public void Exercise2_SoftUni_QAAutomation_HeadingAssert()
        {            
            _softUniHomePage.HomePageTrainingsButton.Click();
            
            _homepageNavigationBar.NavigateToQAAutmationModulePage();

            _qaAutomationModulePage.QAAutomationCourseLink.Click();
                        
            _qaCousePage.AssertHeadingHasCorrectText("QA Automation - май 2020");
            
        }

        [TearDown]
        public void TearDown()
        {
          Driver.Quit();
        }
    }
}
