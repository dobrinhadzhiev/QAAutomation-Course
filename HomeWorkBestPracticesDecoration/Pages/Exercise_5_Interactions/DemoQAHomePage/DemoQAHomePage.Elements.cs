using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DemoQAHomePage
{
    public partial class DemoQAHomePage
    {
        
        public WebElement CategoryOption(string option) => Driver.FindElement(By.XPath($"//*[normalize-space(text())='{option}']/ancestor::div[contains(@class, 'top-card')]"));
    }
}
