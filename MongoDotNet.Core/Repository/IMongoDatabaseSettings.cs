using System;

namespace MongoDotNet.Core.Repository
{
    public interface IMongoDatabaseSettings
    {
        String BooksCollectionName {get; set;}
        String ConnectionString {get; set;}
        String DatabaseName {get; set;}
    }    
}