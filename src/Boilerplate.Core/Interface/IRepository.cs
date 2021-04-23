using System;
using System.Collections.Generic;

namespace Boilerplate.Core.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Guid id);
        void Edit(TEntity entity);

        TEntity GetById(Guid id);
        IEnumerable<TEntity> Filter();
        IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate);

        void SaveChanges();
    }
}