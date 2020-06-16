using NUnit.Framework;
using HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreHomePage;
using HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreAuthenticationPage;
using HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreCreateAnAccountPage;
using AutoFixture;

namespace HomeWorkBestPractices.Tests.Exercise_3_4_AutomationPracticeRegistrationTests
{
    class EmailValidationTest : BaseTest
    {
        private MyStoreHomePage _myStoreHomePage;
        private MyStoreAuthenticationPage _myStoreAuthenticationPage;
        private MyStoreCreateAnAccountPage _myStoreCreateAnAccountPage;
     

        [SetUp]
        public void SetUp()
        {
            Initialize();           
            _myStoreHomePage = new MyStoreHomePage(Driver);
            _myStoreAuthenticationPage = new MyStoreAuthenticationPage(Driver);
            _myStoreCreateAnAccountPage = new MyStoreCreateAnAccountPage(Driver);
            _myStoreHomePage.NavigateTo();
          
        }


        //Submit valid E-mail and check if the same e-mail is displayed in the registration form
        [Test]
        public void Exercise3_AutomationPracticeRegistrationEmailValidation()
        {

            string _email = Fixture.Create<string>();

           
            _myStoreHomePage.HomePageSignInButton.Click();
                        
            _myStoreAuthenticationPage.SubmitValidEmail(_email);

                        
            _myStoreCreateAnAccountPage.AssertTheSameEmailIsDisplayed(_email);

            
        }

        


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
