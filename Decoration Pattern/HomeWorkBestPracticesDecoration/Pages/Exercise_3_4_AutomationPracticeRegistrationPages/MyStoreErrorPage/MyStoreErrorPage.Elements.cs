using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreErrorPage
{
    public partial class MyStoreErrorPage
    {
        public WebElement ErrorMessage => Driver.FindElement(By.XPath("//div[@class='alert alert-danger']//li"));
    }
}
