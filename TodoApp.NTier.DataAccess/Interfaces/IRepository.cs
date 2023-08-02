﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.NTier.DataAccess.Interfaces
{
   public interface IRepository<T> where T : class, new()
    {
        Task<List<T>> GetAll();

        Task<T> GetById(object id);
        Task<T> GetByFilter(Expression<Func<T, bool>> filter, bool asNoTracking = false);

        Task Create(T entity);

        Task Update(T entity);

        Task Remove(T entity);
    }
}
