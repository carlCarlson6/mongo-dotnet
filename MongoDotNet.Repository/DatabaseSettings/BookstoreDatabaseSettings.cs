using System;
using MongoDotNet.Core.Repository;

namespace MongoDotNet.Repository.DatabaseSettings
{
    public class BookstoreDatabaseSettings : IMongoDatabaseSettings
    {
        public String CollectionName { get; set; }
        public String ConnectionString { get; set; }
        public String DatabaseName { get; set; }
    }
}
