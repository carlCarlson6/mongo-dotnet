using System;
using MongoDotNet.Core.Models;

namespace MongoDotNet.Api.Models
{
    public class AddUserResponse: IUser
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
    
        public AddUserResponse(IUser user) 
        {
            this.Id = user.Id;
            this.Name = user.Name;
            this.Password = user.Password;
        }

    }
}
