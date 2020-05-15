using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStore.Domain.Interfaces.Repositories
{
    public interface IRepository<TKey,T>
    {
        void Create(T entity);
        T Read(TKey id);
        IEnumerable<T> ReadAll();
        void Update(T entity);
        void Delete(TKey id);
        void SaveChanges();
    }
}
