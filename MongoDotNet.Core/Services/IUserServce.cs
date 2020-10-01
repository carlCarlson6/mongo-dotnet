using System;

namespace MongoDotNet.Core.Services
{
    public interface IUserService : ICrudService<IUserService>
    {
        void Authenticate();
    }
}
