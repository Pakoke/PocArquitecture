namespace PocArquitecture.Interfaces
{
    using System;

    /// <summary>
    /// Defines the <see cref="IGenericUoW" />
    /// </summary>
    public interface IGenericUoW : IDisposable
    {
        /// <summary>
        /// The Repository
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns>The <see cref="IGenericRepository{TEntity}"/></returns>
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;

        /// <summary>
        /// The SaveChanges
        /// </summary>
        void SaveChanges();
    }
}
