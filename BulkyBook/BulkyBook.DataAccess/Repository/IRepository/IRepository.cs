﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
   public interface IRepository<T> where T :class
    {
        T GET(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>,IOrderedEnumerable<T>> orderBy = null,
            string includeProperties = null
            );
        T GEtFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity);

        void Remove(int id);
        void Remove(T entity);

        void RemoveRenge(IEnumerable<T> entity);


    }
}
