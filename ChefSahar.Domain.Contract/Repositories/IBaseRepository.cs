using ChefSahar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Domain.Contract.Repositories
{
    public interface IBaseRepository<TEntity>  : IRepository
    {
        string Add(TEntity entity);
        string Update(TEntity entity);
        string Delete(TEntity entity);
        TEntity Find(object Key);
        List<TEntity> GetAll();
        List<TEntity> GetAll(short CurrentPage = 1, short CountOnPage = 1);
    }
}
