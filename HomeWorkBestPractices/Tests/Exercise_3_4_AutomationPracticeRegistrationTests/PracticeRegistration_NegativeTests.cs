using NUnit.Framework;
using HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreHomePage;
using HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreAuthenticationPage;
using HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreCreateAnAccountPage;
using HomeWorkBestPractices.Factories;
using HomeWorkBestPractices.Models;
using AutoFixture;
using HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreErrorPage;

namespace HomeWorkBestPractices.Tests.Exercise_3_4_AutomationPracticeRegistrationTests
{
    class PracticeRegistration_NegativeTests : BaseTest
    {
         
        private MyStoreHomePage _myStoreHomePage;
        private MyStoreAuthenticationPage _myStoreAuthenticationPage;
        private MyStoreCreateAnAccountPage _myStoreCreateAnAccountPage;
        private MyStoreErrorPage _myStoreErrorPage;
        private PracticeRegistrationModel _user;
        private string _email;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _myStoreHomePage = new MyStoreHomePage(Driver);
            _myStoreAuthenticationPage = new MyStoreAuthenticationPage(Driver);
            _myStoreCreateAnAccountPage = new MyStoreCreateAnAccountPage(Driver);
            _myStoreErrorPage = new MyStoreErrorPage(Driver);
            _user = PracticeRegistrationFactory.CreateUser();
            _myStoreHomePage.NavigateTo();
            _email = Fixture.Create<string>();
        }

        [Test]        
        public void Exercise4_AssertErrorText_WhenFirstNameIsEmpty()
        {
            _user.FirstName = string.Empty;


            _myStoreHomePage.HomePageSignInButton.Click();
            
            _myStoreAuthenticationPage.SubmitValidEmail(_email);

            _myStoreCreateAnAccountPage.FillUserInformation(_user);


            _myStoreErrorPage.AssertCorrectErrorMessageIsDisplayed("firstname is required.");
           
        }

        [Test]
        public void Exercise4_AssertErrorText_WhenLastNameIsEmpty()
        {
            _user.LastName = string.Empty;


            _myStoreHomePage.HomePageSignInButton.Click();

            _myStoreAuthenticationPage.SubmitValidEmail(_email);

            _myStoreCreateAnAccountPage.FillUserInformation(_user);


            _myStoreErrorPage.AssertCorrectErrorMessageIsDisplayed("lastname is required.");

        }

        [Test]
        public void Exercise4_AssertErrorText_WhenPasswordFieldIsEmpty()
        {
            _user.Password = string.Empty;


            _myStoreHomePage.HomePageSignInButton.Click();

            _myStoreAuthenticationPage.SubmitValidEmail(_email);

            _myStoreCreateAnAccountPage.FillUserInformation(_user);


            _myStoreErrorPage.AssertCorrectErrorMessageIsDisplayed("passwd is required.");

        }

        [Test]
        public void Exercise4_AssertErrorText_WhenAddressFieldIsEmpty()
        {
            _user.Address = string.Empty;


            _myStoreHomePage.HomePageSignInButton.Click();

            _myStoreAuthenticationPage.SubmitValidEmail(_email);

            _myStoreCreateAnAccountPage.FillUserInformation(_user);


            _myStoreErrorPage.AssertCorrectErrorMessageIsDisplayed("address1 is required.");

        }

        [Test]
        public void Exercise4_AssertErrorText_WhenMobileNumberFieldIsEmpty()
        {
            _user.Phonenumber = string.Empty;


            _myStoreHomePage.HomePageSignInButton.Click();

            _myStoreAuthenticationPage.SubmitValidEmail(_email);

            _myStoreCreateAnAccountPage.FillUserInformation(_user);


            _myStoreErrorPage.AssertCorrectErrorMessageIsDisplayed("You must register at least one phone number.");

        }




        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}

