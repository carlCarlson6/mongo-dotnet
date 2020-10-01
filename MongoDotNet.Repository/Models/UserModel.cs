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
        public String Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
    }
}
