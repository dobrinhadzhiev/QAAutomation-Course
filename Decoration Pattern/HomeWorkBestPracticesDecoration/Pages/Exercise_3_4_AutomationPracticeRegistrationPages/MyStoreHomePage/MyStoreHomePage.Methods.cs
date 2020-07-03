using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreHomePage
{
    public partial class MyStoreHomePage : BasePage
    {

        public MyStoreHomePage(WebDriver driver) : base(driver)
        {
        }

        public override string Url => "http://automationpractice.com/index.php";

       
    }
}
