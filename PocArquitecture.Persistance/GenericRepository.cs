namespace PocArquitecture.Persistance
{
    using Microsoft.EntityFrameworkCore;
    using PocArquitecture.Interfaces;
    using PocArquitecture.Persistance.Context;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="GenericRepository{TEntity}" />
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Defines the DbContext
        /// </summary>
        protected readonly PocArquitectureContext DbContext;

        /// <summary>
        /// Defines the _objectSet
        /// </summary>
        protected DbSet<TEntity> _objectSet;


        private bool Cacheable;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="dbContext">The dbContext<see cref="PocArquitectureContext"/></param>
        public GenericRepository(PocArquitectureContext dbContext, bool cacheable = false)
        {
            DbContext = dbContext;
            _objectSet = DbContext.Set<TEntity>();
            this.Cacheable = cacheable;
        }

        /// <summary>
        /// The GetById
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="TEntity"/></returns>
        public virtual TEntity GetById(int id)
        {
            return _objectSet.Find(id);
        }

        /// <summary>
        /// The GetById
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>The <see cref="TEntity"/></returns>
        public virtual TEntity GetById(string id)
        {
            return _objectSet.Find(id);
        }

        /// <summary>
        /// The GetById
        /// </summary>
        /// <param name="id">The id<see cref="object[]"/></param>
        /// <returns>The <see cref="TEntity"/></returns>
        public virtual TEntity GetById(params object[] id)
        {
            return _objectSet.Find(id);
        }

        /// <summary>
        /// The GetAll
        /// </summary>
        /// <returns>The <see cref="IEnumerable{TEntity}"/></returns>
        public virtual IEnumerable<TEntity> GetAll()
        {
            //Add to list, to execute the query inside of the repo.
            return _objectSet.AsEnumerable().ToList();
        }

        /// <summary>
        /// The Get
        /// </summary>
        /// <param name="predicate">The predicate<see cref="Func{TEntity, bool}"/></param>
        /// <returns>The <see cref="TEntity"/></returns>
        public TEntity Get(Func<TEntity, bool> predicate)
        {
            return _objectSet.FirstOrDefault(predicate);
        }

        /// <summary>
        /// The Add
        /// </summary>
        /// <param name="entity">The entity<see cref="TEntity"/></param>
        public void Add(TEntity entity)
        {
            _objectSet.Add(entity);
        }

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="entity">The entity<see cref="TEntity"/></param>
        public void Delete(TEntity entity)
        {
            _objectSet.Remove(entity);
        }

        /// <summary>
        /// The Edit
        /// </summary>
        /// <param name="entity">The entity<see cref="TEntity"/></param>
        public void Edit(TEntity entity)
        {
            _objectSet.Attach(entity);
        }

        /// <summary>
        /// The AddRange
        /// </summary>
        /// <param name="entities">The entities<see cref="IEnumerable{TEntity}"/></param>
        public void AddRange(IEnumerable<TEntity> entities)
        {
            _objectSet.AddRange(entities);
        }

        /// <summary>
        /// The DeleteRange
        /// </summary>
        /// <param name="entities">The entities<see cref="IEnumerable{TEntity}"/></param>
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _objectSet.RemoveRange(entities);
        }
    }
}
