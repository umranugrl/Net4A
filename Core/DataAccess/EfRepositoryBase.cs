using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic type lara constraints (kısıt) verebiliriz.
    public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TContext : DbContext
        where TEntity : Entity
    {
        private readonly TContext Context;

        public EfRepositoryBase(TContext context)
        {
            Context = context;
        }

        public void Add(TEntity entity)
        {
            Context.Add(entity);
            Context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            Context.Remove(entity);
            Context.SaveChanges();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>>? predicate = null)
        {
            IQueryable<TEntity> data = Context.Set<TEntity>();
            if(predicate != null)
            {
                data = data.Where(predicate);
            }
            return data.ToList();
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> data = Context.Set<TEntity>();
            return data.FirstOrDefault(predicate);
        }

        public void Update(TEntity entity)
        {
            Context.Update(entity);
            Context.SaveChanges();
        }
    }
}