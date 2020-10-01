using System.Collections.Generic;
using MongoDB.Driver;
using MongoDotNet.Core.Repository;
using MongoDotNet.Core.Models;
using MongoDotNet.Core.Services;
using System.Linq;
using System;
using MongoDB.Bson;
using MongoDotNet.Repository.Models;
using MongoDotNet.Repository.DatabaseSettings;
using System.ComponentModel;

namespace MongoDotNet.Services
{
    public class BookServices : ICrudService<IBook>
    {
        private readonly IMongoCollection<BookModel> booksMongoCollection;
        public BookServices(IMongoDatabaseSettings settings) 
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);

            this.booksMongoCollection = database.GetCollection<BookModel>(settings.CollectionName);
        }

        public List<IBook> Read() 
        {
            IEnumerable<IBook> books = this.booksMongoCollection.Find(book => true).ToList();
            return books.ToList();
        }

        public IBook Read(String id) 
        {
            IBook bookFounded = this.booksMongoCollection.Find(book => book.Id == id).FirstOrDefault();
            return bookFounded;
        }

        public IBook Create(IBook book) 
        {
            book.Id = ObjectId.GenerateNewId().ToString();
            this.booksMongoCollection.InsertOne(new BookModel(book));
            return book;
        }

        public IBook Update(IBook bookToUpdate)
        {
            ReplaceOneResult result = this.booksMongoCollection.ReplaceOne<BookModel>(book => book.Id == bookToUpdate.Id, new BookModel(bookToUpdate));
            return bookToUpdate;
        }

        public void Remove(string id)
        {
            this.booksMongoCollection.DeleteOne(book => book.Id == id);
        }
    }
}
