using AutoFixture;
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
    public class PersonRepositoryTest
    {
        private PocArquitectureContext _context;
        private IPersonRepository _appPersonRepository;
        private IGenericUoW _UoW;

        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PocArquitectureContext>();
            optionsBuilder.UseInMemoryDatabase(databaseName: "pocarquitecturedb");
            _context = new PocArquitectureContext(optionsBuilder.Options);
            _appPersonRepository = new PersonRepository(_context);
            //InMemory doesn´t support transactions
            _UoW = new GenericUoW(_context, createTransaction: false);

        }

        [Test]
        public void AddPerson()
        {

            var fixture = new Fixture();
            var person = fixture.Build<PersonDto>().Create();

            _appPersonRepository.Add(person);
            _UoW.SaveChanges();

            var existingPerson = _appPersonRepository.GetById(person.Dni);
            Assert.IsNotNull(existingPerson);
            Assert.AreSame(person, existingPerson);

        }

        [Test]
        public void DeletePerson()
        {
            var fixture = new Fixture();
            var person = fixture.Build<PersonDto>().Create();
            _appPersonRepository.Add(person);
            _UoW.SaveChanges();

            var existingPerson = _appPersonRepository.GetById(person.Dni);
            Assert.IsNotNull(existingPerson);

            _appPersonRepository.Delete(existingPerson);

            _UoW.SaveChanges();

            var personEliminated = _appPersonRepository.GetById(person.Dni);

            Assert.IsNull(personEliminated);

        }

        [Test]
        public void UpdatePerson()
        {
            var fixture = new Fixture();
            var person = fixture.Build<PersonDto>().Create();

            _appPersonRepository.Add(person);
            _UoW.SaveChanges();

            var existingPerson = _appPersonRepository.GetById(person.Dni);
            Assert.IsNotNull(existingPerson);
            Assert.AreEqual(existingPerson.GivenName, person.GivenName);

            string newNamePerson = "NewPersonName";

            existingPerson.Name = newNamePerson;

            _appPersonRepository.Edit(existingPerson);

            _UoW.SaveChanges();

            var personUpdated = _appPersonRepository.GetById(person.Dni);

            Assert.IsNotNull(personUpdated);
            Assert.AreEqual(personUpdated.Name, newNamePerson);


        }
    }
}
