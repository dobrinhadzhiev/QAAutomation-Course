using System;
using System.Collections.Generic;
using System.Text;
using WebServicesHomework.Model;

namespace WebServicesHomework.Factory
{
    public static class UserFactory
    {
        public static User CreateNewUser(long householdID)
        {
            var randomUserNumber = new Random().Next(0, 100);

            return new User
            {
                Email = $"user{randomUserNumber}@bookstore.com",
                FirstName = $"Firstname{randomUserNumber}",
                LastName = $"Lastname{randomUserNumber}",
                HouseholdId = householdID
            };
        }
    }
}
