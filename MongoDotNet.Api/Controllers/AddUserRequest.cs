using System;
using MongoDotNet.Core.Models;

namespace MongoDotNet.Api.Models
{
    public class AddUserRequest : IUser
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
    }
}