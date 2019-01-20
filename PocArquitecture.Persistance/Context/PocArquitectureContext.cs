namespace PocArquitecture.Persistance.Context
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using PocArquitecture.Persistance.Configuration;
    using System;

    /// <summary>
    /// Defines the <see cref="PocArquitectureContext" />
    /// </summary>
    public class PocArquitectureContext : DbContext
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PocArquitectureContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{PocArquitectureContext}"/></param>
        public PocArquitectureContext(DbContextOptions<PocArquitectureContext> options) : base(options)
        {
        }

        /// <summary>
        /// The OnModelCreating
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="ModelBuilder"/></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ClubConfiguration());
            modelBuilder.ApplyConfiguration(new EmailConfirmationConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigurationConfiguration());
        }

        /// <summary>
        /// The GetEntry
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity">The entity<see cref="TEntity"/></param>
        /// <returns>The <see cref="EntityEntry{TEntity}"/></returns>
        public EntityEntry<TEntity> GetEntry<TEntity>(TEntity entity) where TEntity : class
        {
            return Entry(entity);
        }

        /// <summary>
        /// The GetSet
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns>The <see cref="DbSet{TEntity}"/></returns>
        public DbSet<TEntity> GetSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        /// <summary>
        /// The SaveChanges
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception e)
            {

                throw new ApplicationException("DbEntityValidationException thrown during SaveChanges: " + e.Message, e);
            }
        }
    }
}
