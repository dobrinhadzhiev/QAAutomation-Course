using NUnit.Framework;
using RestSharp;
using System;
using WebServicesHomework.Factory;
using WebServicesHomework.Model;

namespace WebServicesHomework
{
    class Endpoints
    {
        private RestClient _restclient;

        [SetUp]
     public void SetUp()
        {
            _restclient = new RestClient();
            _restclient.BaseUrl = new Uri("http://localhost:3000");
            _restclient.AddDefaultHeader("G-Token", "ROM831ESV");
            _restclient.AddDefaultHeader("Content-Type", "application/json");
            _restclient.AddDefaultHeader("Authorization", "Basic YWRtaW46YWRtaW4=");
        }


        //*** GET Endpoints ***

        [Test]
        public void GETAllbooks()
        {

            var request = new RestRequest("/books");

            var response = _restclient.Get(request);
            var book = JsonExtensions.FromJsonList<Book>(response.Content);

            Assert.IsTrue(response.IsSuccessful);
        }

        
        [Test]
        public void GETBookById()
        {
            int bookID = 1;
            var request = new RestRequest($"/books/{bookID}");

            var response = _restclient.Get(request);
            var book = JsonExtensions.FromJson<Book>(response.Content);

            Assert.IsTrue(response.IsSuccessful);
        }

        [Test]
        public void SearchBook()
        {
            var request = new RestRequest("/books/search?");
            request.AddQueryParameter("title", "Lectures to My Students");

            var response = _restclient.Get(request);
            var book = JsonExtensions.FromJsonList<Book>(response.Content);

            Assert.IsTrue(response.IsSuccessful);
        }

        [Test]
        public void GETAllUsers()
        {
            var request = new RestRequest("/users");

            var response = _restclient.Get(request);
            var users = JsonExtensions.FromJsonList<User>(response.Content);

            Assert.IsTrue(response.IsSuccessful);
        }

        [Test]
        public void GETUserById()
        {
            var userID = 1;
            var request = new RestRequest($"/users/{userID}");

            var response = _restclient.Get(request);
            var users = JsonExtensions.FromJson<User>(response.Content);

            Assert.IsTrue(response.IsSuccessful);
        }

        [Test]
        [TestCase (1)]
        public void GETWishlistByHousehold(long householdID)
        {
            
            var request = new RestRequest($"/households/{householdID}/wishlistBooks");

            var response = _restclient.Get(request);
            var wishlists = JsonExtensions.FromJsonList<Wishlist>(response.Content);


            Assert.IsTrue(response.IsSuccessful);
        }

        //*** POST Endpoints ***

        [Test]
        public void CreateNewBook()
        {
            var book = BookFactory.CreateNewBook();
            var jsonBook = JsonExtensions.ToJson(book);
            var request = new RestRequest("/books", Method.POST);
           

            request.AddJsonBody(jsonBook);    
            var response = _restclient.Post(request);

            Assert.IsTrue(response.IsSuccessful);

        }

        [Test]
        [TestCase (3)]
        public long CreateNewUser(long householdID)
        {
            var user = UserFactory.CreateNewUser(householdID);
            var jsonUser = JsonExtensions.ToJson(user);
            var request = new RestRequest("/users", Method.POST);

            request.AddJsonBody(jsonUser);
            var response = _restclient.Post(request);
            var wishlistID = JsonExtensions.FromJson<User>(response.Content).WishlistId;

            Assert.IsTrue(response.IsSuccessful);

            return wishlistID;
        }

        [Test]
        public long CreateNewHousehold()
        {
            var household = HouseholdFactory.CreateNewHousehold();
            var jsonHousehold = JsonExtensions.ToJson(household);
            var request = new RestRequest("/households", Method.POST);

            request.AddJsonBody(jsonHousehold);
            var response = _restclient.Post(request);
            var householdID = JsonExtensions.FromJson<Household>(response.Content).Id;

            Assert.IsTrue(response.IsSuccessful);

            return householdID;
        }

        [Test]
        [TestCase (7,7)]
        public void AddBookToUsersWishlist(long wishlistID, long bookID)
        {
           
            var request = new RestRequest($"/wishlists/{wishlistID}/books/{bookID}");

            var response = _restclient.Post(request);

            Assert.IsTrue(response.IsSuccessful);
            
        }


        //*** DELETE Endpoint ***

        [Test]
        public void DeleteBook()
        {
            var bookId = 5;
            var request = new RestRequest($"/books/{bookId}");

            var response = _restclient.Delete(request);

            Assert.IsTrue(response.IsSuccessful);

        }
    }
}
