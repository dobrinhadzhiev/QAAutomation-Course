using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DemoQAHomePage
{
    public partial class DemoQAHomePage : BasePage
    {
        public DemoQAHomePage(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/";
    }
}
