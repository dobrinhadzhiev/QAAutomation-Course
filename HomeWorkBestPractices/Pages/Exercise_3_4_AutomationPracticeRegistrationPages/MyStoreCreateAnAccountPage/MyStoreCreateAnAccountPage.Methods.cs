using HomeWorkBestPractices.Models;
using OpenQA.Selenium;


namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreCreateAnAccountPage
{
    public partial class MyStoreCreateAnAccountPage : BasePage
    {
        public MyStoreCreateAnAccountPage(IWebDriver driver) :base(driver)
        {
        }

        public void FillUserInformation(PracticeRegistrationModel user)
        {
            FirstNameField.SendKeys(user.FirstName);
            LastNameField.SendKeys(user.LastName);
            PasswordField.SendKeys(user.Password);
            AddressField.SendKeys(user.Address);
            CityField.SendKeys(user.City);
            SelectState.SelectByText(user.State);
            PostcodeField.SendKeys(user.Postcode);
            PhonenumberField.SendKeys(user.Phonenumber);

            RegisterButton.Click();
        }
    }
}
