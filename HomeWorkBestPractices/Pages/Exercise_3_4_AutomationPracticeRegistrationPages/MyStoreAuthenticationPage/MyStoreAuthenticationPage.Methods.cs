using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreAuthenticationPage
{
    public partial class MyStoreAuthenticationPage : BasePage
    {

        public MyStoreAuthenticationPage(IWebDriver driver) : base(driver)
        {
        }


        public void SubmitValidEmail(string email)
        {
            LoginPageEmailField.SendKeys($"{email}@mydomain.com");
            CreateAnAccountButton.Click();
        }
    }
}
