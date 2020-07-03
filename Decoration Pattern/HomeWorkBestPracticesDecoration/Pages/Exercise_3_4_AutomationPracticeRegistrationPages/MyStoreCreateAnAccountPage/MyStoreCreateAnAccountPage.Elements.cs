using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreCreateAnAccountPage
{
    public partial class MyStoreCreateAnAccountPage
    {

        public WebElement FirstNameField => Driver.FindElement(By.Id("customer_firstname"));

        public WebElement LastNameField => Driver.FindElement(By.Id("customer_lastname"));

        public WebElement EmailField => Driver.FindElement(By.XPath("//label[normalize-space(text())='Email']//following-sibling::input"));

        public WebElement PasswordField => Driver.FindElement(By.Id("passwd"));

        public WebElement AddressField => Driver.FindElement(By.Id("address1"));

        public WebElement CityField => Driver.FindElement(By.Id("city"));

        public SelectElement SelectState => new SelectElement(Driver.WrappedDriver.FindElement(By.Id("id_state")));

        public WebElement PostcodeField => Driver.FindElement(By.Id("postcode"));

        public WebElement PhonenumberField => Driver.FindElement(By.Id("phone_mobile"));

        public WebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));

    }
}
