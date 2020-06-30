using HomeWorkBestPractices.Models;
using OpenQA.Selenium;
using StabilizeCore;

namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreCreateAnAccountPage
{
    public partial class MyStoreCreateAnAccountPage : BasePage
    {
        public MyStoreCreateAnAccountPage(WebDriver driver) :base(driver)
        {
        }

        public void FillUserInformation(PracticeRegistrationModel user)
        {
            FirstNameField.SetText(user.FirstName);
            LastNameField.SetText(user.LastName);
            PasswordField.SetText(user.Password);
            AddressField.SetText(user.Address);
            CityField.SetText(user.City);
            SelectState.SelectByText(user.State);
            PostcodeField.SetText(user.Postcode);
            PhonenumberField.SetText(user.Phonenumber);

            RegisterButton.Click();
        }
    }
}
