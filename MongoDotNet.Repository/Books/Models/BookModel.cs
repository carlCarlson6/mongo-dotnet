using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDotNet.Core.Models;

namespace MongoDotNet.Repository.Books.Models
{
    public class BookModel : IBook
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }
        public String Name { get; set; }
        public float Price { get; set; }
        public String Category { get; set; }
        public String Author { get; set; }
    }
}