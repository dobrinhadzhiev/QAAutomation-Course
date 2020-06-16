using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.Homepage
{
    public partial class SoftUniHomePage : BasePage
    {
        public SoftUniHomePage(IWebDriver driver)
            : base(driver)
        {
        }

       
        public override string Url => "https://softuni.bg";
    }
}
