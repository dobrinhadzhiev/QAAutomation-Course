using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreHomePage
{
    public partial class MyStoreHomePage
    {
        
       public IWebElement HomePageSignInButton => Driver.FindElement(By.LinkText("Sign in"));
                  
    }
}
