
using System;

namespace MongoDotNet.Core.Models
{
    public interface IBook
    {
        String Id {get; set;}
        String Name {get; set;}
        float Price {get; set;}
        String Category {get; set;}
        String Author {get; set;}
    }    
}
