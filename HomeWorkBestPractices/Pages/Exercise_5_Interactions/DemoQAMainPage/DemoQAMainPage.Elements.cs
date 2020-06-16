using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DemoQAMainPage
{
    public partial class DemoQAMainPage
    {
        public IWebElement OptionsPanel => Driver.FindElement(By.XPath("//*[@class='left-pannel']"));

        public IWebElement SubMenu(string option) => OptionsPanel.FindElement(By.XPath($".//*[normalize-space(text())='{option}']"));

        public IWebElement PageHeader => Driver.FindElement(By.ClassName("main-header"));
    }
}
