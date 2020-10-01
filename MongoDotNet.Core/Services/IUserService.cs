using MongoDotNet.Core.Models;

namespace MongoDotNet.Core.Services
{
    public interface IUserService : ICrudService<IUser>
    {
        void Authenticate();
    }
}
