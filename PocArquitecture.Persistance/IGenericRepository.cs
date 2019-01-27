namespace PocArquitecture.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IGenericRepository{TEntity}" />
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// The GetAll
        /// </summary>
        /// <returns>The <see cref="IEnumerable{TEntity}"/></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// The GetById
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>The <see cref="TEntity"/></returns>
        TEntity GetById(string id);

        /// <summary>
        /// The GetById
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="TEntity"/></returns>
        TEntity GetById(int id);

        /// <summary>
        /// The GetById
        /// </summary>
        /// <param name="id">The id<see cref="object[]"/></param>
        /// <returns>The <see cref="TEntity"/></returns>
        TEntity GetById(params object[] id);

        /// <summary>
        /// The Add
        /// </summary>
        /// <param name="entity">The entity<see cref="TEntity"/></param>
        void Add(TEntity entity);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="TEntity"/></param>
        void Delete(TEntity entity);

        /// <summary>
        /// The Edit
        /// </summary>
        /// <param name="entity">The entity<see cref="TEntity"/></param>
        void Edit(TEntity entity);

        /// <summary>
        /// The AddRange
        /// </summary>
        /// <param name="entities">The entities<see cref="IEnumerable{TEntity}"/></param>
        void AddRange(IEnumerable<TEntity> entities);

        /// <summary>
        /// The DeleteRange
        /// </summary>
        /// <param name="entities">The entities<see cref="IEnumerable{TEntity}"/></param>
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
