using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreAuthenticationPage
{
    public partial class MyStoreAuthenticationPage
    {

      public  IWebElement LoginPageEmailField => Driver.FindElement(By.Id("email_create"));

      public IWebElement CreateAnAccountButton => Driver.FindElement(By.Name("SubmitCreate"));
                      
        
    }
}
