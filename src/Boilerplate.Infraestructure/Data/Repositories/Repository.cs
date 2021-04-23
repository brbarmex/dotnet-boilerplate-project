using System;
using System.Collections.Generic;
using System.Linq;
using Boilerplate.Core.Interface;
using Boilerplate.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Boilerplate.Infraestructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly BoilerplateDbContext DbContext;
        private readonly DbSet<TEntity> Table;

        public Repository(BoilerplateDbContext context)
        {
            DbContext = context;
            Table = DbContext.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            Table.Add(entity);
            DbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
        }

        public void Delete(Guid id)
        {
        }

        public void Edit(TEntity entity)
        {
        }

        public IEnumerable<TEntity> Filter()
        {
            return Table.ToList();
        }

        public IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate)
        {
            return null;
        }

        public TEntity GetById(Guid id)
        {
            return null;
        }

        public void SaveChanges()
        {
        }
    }
}