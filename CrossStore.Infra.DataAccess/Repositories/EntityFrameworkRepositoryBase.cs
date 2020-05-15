using CrossStore.Domain.Entities;
using CrossStore.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStore.Infra.DataAccess.Repositories
{
    public abstract class EntityFrameworkRepositoryBase<TKey, T> : IRepository<TKey,T> where T : TEntity<TKey>
    {
        private DbContext db;

        protected EntityFrameworkRepositoryBase(DbContext db)
        {
            this.db = db;
        }

        public void Create(T entity)
        {
            db.Set<T>().Add(entity);
        }

        public void Delete(TKey id)
        {
            db.Set<T>().Remove(Read(id));
        }

        public T Read(TKey id)
        {
            return db.Set<T>().Find(id);
        }

        public IEnumerable<T> ReadAll()
        {
            return db.Set<T>();
        }

        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
