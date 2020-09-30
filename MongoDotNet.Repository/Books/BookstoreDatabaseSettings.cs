using System;
using MongoDotNet.Core.Repository;

namespace MongoDotNet.Repository.Books
{
    public class BookstoreDatabaseSettings : IMongoDatabaseSettings
    {
        public String BooksCollectionName { get; set; }
        public String ConnectionString { get; set; }
        public String DatabaseName { get; set; }
    }
}
