using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDotNet.Core.Models;
using MongoDotNet.Core.Repository;
using MongoDotNet.Core.Services;
using MongoDotNet.Repository.Models;

namespace MongoDotNet.Services
{
    public class UserServices : IUserService
    {    
        private readonly IMongoCollection<UserModel> usersMongoCollection;
        public UserServices(IMongoDatabaseSettings<IUser> settings) 
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);
            this.usersMongoCollection = database.GetCollection<UserModel>(settings.CollectionName);
        }

        public void Authenticate()
        {
            throw new NotImplementedException();
        }

        public IUser Create(IUser entity)
        {
            throw new NotImplementedException();
        }

        public List<IUser> Read()
        {
            throw new NotImplementedException();
        }

        public IUser Read(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public IUser Update(IUser entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
