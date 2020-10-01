using System;

namespace MongoDotNet.Core.Models
{
    public interface IUser
    {
        String Id {get; set;}
        String Name {get; set;}
        String Password {get; set;}
    }
}
