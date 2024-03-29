﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.DAL.Repository.Interface
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
        IEnumerable<TEntity> GetAll();
        Task<TEntity> GetAsync(int id);
    }
}
