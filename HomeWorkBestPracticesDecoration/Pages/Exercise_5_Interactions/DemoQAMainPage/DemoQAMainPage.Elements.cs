using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DemoQAMainPage
{
    public partial class DemoQAMainPage
    {
        public WebElement OptionsPanel => Driver.FindElement(By.XPath("//*[@class='left-pannel']"));

        public WebElement SubMenu(string option) => OptionsPanel.FindElement(By.XPath($".//*[normalize-space(text())='{option}']"));

        public WebElement PageHeader => Driver.FindElement(By.ClassName("main-header"));
    }
}
