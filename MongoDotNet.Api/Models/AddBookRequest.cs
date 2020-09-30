using MongoDotNet.Core.Models;

namespace MongoDotNet.Api.Models
{
    public class AddBookRequest : IBook
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}