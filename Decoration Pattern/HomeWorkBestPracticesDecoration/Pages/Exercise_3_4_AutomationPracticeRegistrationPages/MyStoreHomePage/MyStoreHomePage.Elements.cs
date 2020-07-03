using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreHomePage
{
    public partial class MyStoreHomePage
    {
        
       public WebElement HomePageSignInButton => Driver.FindElement(By.LinkText("Sign in"));
                  
    }
}
