using System;
using MongoDB.Driver;
using MongoDotNet.Repository.Books;
using MongoDotNet.Repository.Books.Models;

namespace MongoDotNet.Services
{
    public class BookServices
    {
        private readonly IMongoCollection<BookModel> books;

        public BookServices(BookstoreDatabaseSettings settings)
        {
            
        }
    }
}
