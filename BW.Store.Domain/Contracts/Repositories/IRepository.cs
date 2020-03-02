using BW.Store.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BW.Store.Domain.Contracts.Repositories
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        IEnumerable<T> Get();
        T Get(int id);
    }
}
