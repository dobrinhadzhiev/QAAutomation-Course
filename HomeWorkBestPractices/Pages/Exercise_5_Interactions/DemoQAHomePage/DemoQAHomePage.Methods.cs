using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.DemoQAHomePage
{
    public partial class DemoQAHomePage : BasePage
    {
        public DemoQAHomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/";
    }
}
