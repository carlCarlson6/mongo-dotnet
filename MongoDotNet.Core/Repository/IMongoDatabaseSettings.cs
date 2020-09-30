using System;

namespace MongoDotNet.Core.Repository
{
    public interface IMongoDatabaseSettings
    {
        String CollectionName {get; set;}
        String ConnectionString {get; set;}
        String DatabaseName {get; set;}
    }    
}