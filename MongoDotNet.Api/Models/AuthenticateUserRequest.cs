using System;
using MongoDotNet.Core.Models;

namespace MongoDotNet.Api.Models
{
    public class AuthenticateUserRequest
    {
        public IUser User {get; set;}
        
        public AuthenticateUserRequest(IUser user) 
        {
            this.User = user;
        }
    }
}
