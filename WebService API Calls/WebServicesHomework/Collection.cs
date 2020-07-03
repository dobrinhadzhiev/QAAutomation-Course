using NUnit.Framework;

namespace WebServicesHomework
{
    class Collection : Endpoints
    {
      

        [SetUp]
        public void Initialize()
        {
            SetUp();           
        }


        //*Add a new household
        //*Add two different users
        //*Add two books for each user
        //*Get a wishlist for a created household 
        [Test]
        public void Exercise3_AddCollectionOfRequests()
        {
            var householdID = CreateNewHousehold();
            var bookId = 0;

            for (int i=1; i<=2; i++)
            {
                var wishlistID = CreateNewUser(householdID);

                for (int j=1; j<=2; j++)
                {
                    bookId++;
                    AddBookToUsersWishlist(wishlistID, bookId);
                }
                
            }

            GETWishlistByHousehold(householdID);

        }
    }
}
