using System;

namespace PocArquitecture.Interfaces
{
    public interface IGenericUoW : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;

        void SaveChanges();

    }
}
