using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using PocArquitecture.Interfaces;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;
using PocArquitecture.Persistance.Repositories;

namespace PocArquitecture.Persistance.Test
{
    [TestFixture]
    public class AppConfigurationRepositoryTest
    {
        private PocArquitectureContext _context;
        private IAppConfigurationRepository _appConfigurationRepository;
        private IGenericUoW _UoW;

        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PocArquitectureContext>();
            optionsBuilder.UseInMemoryDatabase(databaseName: "pocarquitecturedb");
            _context = new PocArquitectureContext(optionsBuilder.Options);
            _appConfigurationRepository = new AppConfigurationRepository(_context);
            //InMemory doesn´t support transactions
            _UoW = new GenericUoW(_context, createTransaction: false);

        }

        [Test]
        public void AddConfiguration()
        {

            var configuration = new AppConfigurationDto()
            {
                AppConfigurationId = 2,
                Description = "Test Configuration",
                Name = "Test",
                Value = "Test"
            };
            _appConfigurationRepository.Add(configuration);
            _UoW.SaveChanges();

            var existingConfiguration = _appConfigurationRepository.GetById(configuration.AppConfigurationId);
            Assert.IsNotNull(existingConfiguration);
            _appConfigurationRepository.Delete(configuration);
            _UoW.SaveChanges();

        }

        [Test]
        public void DeleteConfiguration()
        {
            var configuration = new AppConfigurationDto()
            {
                AppConfigurationId = 2,
                Description = "Test Configuration",
                Name = "Test",
                Value = "Test"
            };
            _appConfigurationRepository.Add(configuration);
            _UoW.SaveChanges();

            var existingConfiguration = _appConfigurationRepository.GetById(configuration.AppConfigurationId);
            Assert.IsNotNull(existingConfiguration);

            _appConfigurationRepository.Delete(existingConfiguration);

            _UoW.SaveChanges();

            var configurationEliminated = _appConfigurationRepository.GetById(configuration.AppConfigurationId);

            Assert.IsNull(configurationEliminated);

        }

        [Test]
        public void UpdateConfiguration()
        {
            var configuration = new AppConfigurationDto()
            {
                AppConfigurationId = 2,
                Description = "Test Configuration",
                Name = "Test",
                Value = "Test"
            };
            _appConfigurationRepository.Add(configuration);
            _UoW.SaveChanges();

            var existingConfiguration = _appConfigurationRepository.GetById(configuration.AppConfigurationId);
            Assert.IsNotNull(existingConfiguration);
            Assert.AreEqual(existingConfiguration.Name, "Test");

            string newNameConfig = "TestUpdated";

            existingConfiguration.Name = newNameConfig;

            _appConfigurationRepository.Edit(existingConfiguration);

            _UoW.SaveChanges();

            var configurationUpdated = _appConfigurationRepository.GetById(configuration.AppConfigurationId);

            Assert.IsNotNull(configurationUpdated);
            Assert.AreEqual(configurationUpdated.Name, newNameConfig);


        }


    }
}
