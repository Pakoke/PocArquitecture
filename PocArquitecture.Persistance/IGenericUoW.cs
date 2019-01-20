using System;

namespace PocArquitecture.Persistance
{
    public interface IGenericUoW : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;

        void SaveChanges();

    }
}
