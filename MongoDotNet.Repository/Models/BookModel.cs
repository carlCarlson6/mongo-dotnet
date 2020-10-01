using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDotNet.Core.Models;

namespace MongoDotNet.Repository.Models
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
 
        public BookModel(IBook book) 
        {
            this.Id = book.Id;
            this.Name = book.Name;
            this.Price = book.Price;
            this.Category = book.Category;
            this.Author = book.Author;
        }

        public BookModel(String id, String name, float price, String category, String author) 
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.Author = author;
        }
    }
}