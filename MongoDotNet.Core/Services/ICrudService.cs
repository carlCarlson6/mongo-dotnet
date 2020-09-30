using System;
using System.Collections.Generic;

namespace MongoDotNet.Core.Services
{
    public interface ICrudService<T>
    {
        T Create(T entity);
        List<T> Read();
        T Read(String id);
        T Update(T entityToUpdate);
        void Remove(String id);
    }
}
