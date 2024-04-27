﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public TEntity? GetById(int id)
        {
            return Context.Set<TEntity>().FirstOrDefault(i=>i.Id == id);
        }

        public void Update(TEntity entity)
        {
            Context.Update(entity);
            Context.SaveChanges();
        }
    }
}