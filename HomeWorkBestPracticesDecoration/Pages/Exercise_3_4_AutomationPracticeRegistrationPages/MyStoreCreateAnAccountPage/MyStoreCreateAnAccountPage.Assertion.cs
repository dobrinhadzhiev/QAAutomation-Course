using NUnit.Framework;


namespace HomeWorkBestPractices.Pages.Exercise_3_4_AutomationPracticeRegistrationPages.MyStoreCreateAnAccountPage
{
    public partial class MyStoreCreateAnAccountPage
    {
               
        public void AssertTheSameEmailIsDisplayed(string email)
        {
            Assert.AreEqual($"{email}@mydomain.com", EmailField.GetAttribute("value"));

        }
    }
}
