using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreCreateAnAccountPage
{
    public partial class MyStoreCreateAnAccountPage
    {

        public IWebElement FirstNameField => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastNameField => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement EmailField => Driver.FindElement(By.XPath("//label[normalize-space(text())='Email']//following-sibling::input"));

        public IWebElement PasswordField => Driver.FindElement(By.Id("passwd"));

        public IWebElement AddressField => Driver.FindElement(By.Id("address1"));

        public IWebElement CityField => Driver.FindElement(By.Id("city"));

        public SelectElement SelectState => new SelectElement(Driver.FindElement(By.Id("id_state")));

        public IWebElement PostcodeField => Driver.FindElement(By.Id("postcode"));

        public IWebElement PhonenumberField => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));

    }
}
