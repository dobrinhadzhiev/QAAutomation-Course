using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreErrorPage
{
    public partial class MyStoreErrorPage
    {
        public IWebElement ErrorMessage => Driver.FindElement(By.XPath("//div[@class='alert alert-danger']//li"));
    }
}
