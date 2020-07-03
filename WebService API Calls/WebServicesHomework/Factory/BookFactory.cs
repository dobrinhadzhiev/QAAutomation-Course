using System;
using System.Collections.Generic;
using System.Text;
using WebServicesHomework.Model;

namespace WebServicesHomework.Factory
{
    public static class BookFactory
    {
        public static Book CreateNewBook()
        {
            var randomBookNumber = new Random().Next(0, 100);
            var randomISBN = new Random().Next(100000000, 999999999);

            return new Book
            {
                Title = $"Book{randomBookNumber}",
                Author = "Famous Author",
                Isbn = randomISBN,
                PublicationDate = DateTime.Now
            };
        }
    }
}
