using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDotNet.Core.Models;
using MongoDotNet.Core.Repository;
using MongoDotNet.Core.Services;
using MongoDotNet.Repository.Models;
using System.Linq;
using MongoDotNet.Common;

namespace MongoDotNet.Services
{
    public class UserServices : ICrudService<IUser>
    {
    {    
        private readonly IMongoCollection<UserModel> usersMongoCollection;
        private readonly PasswordUtils passwordUtils;
        public UserServices(IMongoDatabaseSettings<IUser> settings, PasswordUtils passwordUtils) 
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);
            this.usersMongoCollection = database.GetCollection<UserModel>(settings.CollectionName);

            this.passwordUtils = passwordUtils;
        }

        public IUser Create(IUser user)
        {
            user.Id = ObjectId.GenerateNewId().ToString(); 
            user.Password = this.passwordUtils.EncryptPassword(user.Password);

            this.usersMongoCollection.InsertOne(new UserModel(user));
            return user;
        }

        public List<IUser> Read()
        {
            IEnumerable<IUser> users = this.usersMongoCollection.Find(user => true).ToList();
            return users.ToList();
        }

        public IUser Read(String id)
        {
            IUser userFounded = this.usersMongoCollection.Find(user => user.Id == id).FirstOrDefault();
            return userFounded;
        }

        public IUser Update(IUser userToUpdate)
        {
            ReplaceOneResult result = this.usersMongoCollection.ReplaceOne<UserModel>(user => user.Id == userToUpdate.Id, new UserModel(userToUpdate));
            return userToUpdate;
        }

        public void Remove(String id)
        {
            this.usersMongoCollection.DeleteOne(user => user.Id == id);
        }

    }
}
