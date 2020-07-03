using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_2_QAAutomationPages.Homepage
{
    public partial class SoftUniHomePage : BasePage
    {
        public SoftUniHomePage(WebDriver driver)
            : base(driver)
        {
        }

       
        public override string Url => "https://softuni.bg";
    }
}
