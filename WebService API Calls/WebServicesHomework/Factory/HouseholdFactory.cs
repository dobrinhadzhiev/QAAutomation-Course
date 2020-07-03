using System;
using System.Collections.Generic;
using System.Text;
using WebServicesHomework.Model;

namespace WebServicesHomework.Factory
{
    public static class HouseholdFactory
    {
        public static Household CreateNewHousehold()
        {
            var randomHouseholdNumber = new Random().Next(0, 100);

            return new Household
            {
                Name = $"Household{randomHouseholdNumber}"
            };
        }
    }
}
