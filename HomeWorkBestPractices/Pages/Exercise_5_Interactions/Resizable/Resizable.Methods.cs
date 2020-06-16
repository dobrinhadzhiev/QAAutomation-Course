using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_5_Interactions.Resizable
{
    public partial class Resizable : BasePage
    {
        public Resizable(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/resizable";
    }
}
