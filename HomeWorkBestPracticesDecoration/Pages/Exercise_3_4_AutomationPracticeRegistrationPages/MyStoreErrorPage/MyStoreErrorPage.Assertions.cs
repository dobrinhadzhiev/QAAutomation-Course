using NUnit.Framework;
using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreErrorPage
{
    public partial class MyStoreErrorPage : BasePage
    {
        public MyStoreErrorPage(WebDriver driver) : base(driver)
        {
        }

        public void AssertCorrectErrorMessageIsDisplayed(string expectedErrorMessage)
        {
            Assert.AreEqual(expectedErrorMessage, ErrorMessage.Text);
        }
    }
}
