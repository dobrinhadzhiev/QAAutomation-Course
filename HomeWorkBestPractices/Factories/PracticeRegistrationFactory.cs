using HomeWorkBestPractices.Models;


namespace HomeWorkBestPractices.Factories
{
    public static class PracticeRegistrationFactory
    {
        public static PracticeRegistrationModel CreateUser()
        {
            return new PracticeRegistrationModel
            {
                FirstName = "myFirstName",
                LastName = "myLastName",
                Password = "qwerty",
                Address = "myAddress 12345",
                City = "myCity",
                State = "Alabama",
                Postcode = "12345",
                Phonenumber = "0888888888"
            };
        }

    }
}
