using System;
using MongoDotNet.Core.Models;

namespace MongoDotNet.Core.Services
{
    public interface IUserService : ICrudService<IUser>
    {
        String Authenticate(IUser user);

        Boolean ValidateAuthentication(String authToken);
    }
}
