using ChefSahar.Domain.Contract.Interfaces;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChefSahar.Infrascture.DataBase.EF.Repositories
{
      public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : Entity
    {
        protected readonly IDbContext context;
        protected string Result { get; set; }
        public BaseRepository(IDbContext context)
        {
            this.context = context;
        }
        public string Add(TEntity entity)
        {
            Result = context.Set<TEntity>().Add(entity).Entity.ID.ToString();
            context.SaveChanges();


            return Result;
        }

        public string Update(TEntity entity)
        {
            Result = context.Set<TEntity>().Update(entity).State.ToString();
            context.SaveChanges();

            return Result;
        }

        public string Delete(TEntity entity)
        {
            Result = context.Set<TEntity>().Remove(entity).State.ToString();

            context.SaveChanges();

            return Result;
        }

        public TEntity Find(object Key)
        {
           return context.Set<TEntity>().Find(Key);
        }

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().OrderBy(c=>c.ID).ToList();

        }

        public List<TEntity> GetAll(short CurrentPage = 1, short CountOnPage = 1)
        {
            return context.Set<TEntity>().OrderBy(c => c.ID).Skip(CountOnPage * (CurrentPage - 1)).Take(CountOnPage).ToList();
        }

       
    }
}
