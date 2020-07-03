using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreAuthenticationPage
{
    public partial class MyStoreAuthenticationPage
    {

      public  WebElement LoginPageEmailField => Driver.FindElement(By.Id("email_create"));

      public WebElement CreateAnAccountButton => Driver.FindElement(By.Name("SubmitCreate"));
                      
        
    }
}
