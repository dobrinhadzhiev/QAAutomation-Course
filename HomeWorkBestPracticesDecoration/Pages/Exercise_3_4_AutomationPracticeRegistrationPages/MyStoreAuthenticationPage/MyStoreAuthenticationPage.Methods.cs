using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreAuthenticationPage
{
    public partial class MyStoreAuthenticationPage : BasePage
    {

        public MyStoreAuthenticationPage(WebDriver driver) : base(driver)
        {
        }


        public void SubmitValidEmail(string email)
        {
            LoginPageEmailField.SetText($"{email}@mydomain.com");
            CreateAnAccountButton.Click();
        }
    }
}
