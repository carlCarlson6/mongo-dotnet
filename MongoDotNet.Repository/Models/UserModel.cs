using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDotNet.Core.Models;

namespace MongoDotNet.Repository.Models
{
    public class UserModel : IUser
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
