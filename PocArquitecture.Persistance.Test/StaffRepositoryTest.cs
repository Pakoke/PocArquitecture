using AutoFixture;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using PocArquitecture.Interfaces;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;
using PocArquitecture.Persistance.Repositories;
using System;
using System.Linq;

namespace PocArquitecture.Persistance.Test
{
    [TestFixture]
    public class StaffRepositoryTest
    {
        private PocArquitectureContext _context;
        private IStaffRepository _appStaffRepository;
        private IGenericUoW _UoW;

        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PocArquitectureContext>();
            optionsBuilder.UseInMemoryDatabase(databaseName: "pocarquitecturedb");
            _context = new PocArquitectureContext(optionsBuilder.Options);
            _appStaffRepository = new StaffRepository(_context);
            //InMemory doesn´t support transactions
            _UoW = new GenericUoW(_context, createTransaction: false);

        }

        [Test]
        public void AddStaff()
        {

            var fixture = new Fixture();
            var Staff = fixture.Build<StaffDto>().Without(p => p.StaffId).Without(p => p.MovedFired).Create();

            _appStaffRepository.Add(Staff);
            _UoW.SaveChanges();

            var existingStaff = _appStaffRepository.GetStaffByDeparmentAndPersonIdWorking(Staff.DeparmentId, Staff.PersonId);
            Assert.IsNotNull(existingStaff);
            Assert.AreSame(Staff, existingStaff);

        }

        [Test]
        public void DeleteStaff()
        {
            var fixture = new Fixture();
            var Staff = fixture.Build<StaffDto>().Without(p => p.StaffId).Without(p => p.MovedFired).Create();

            _appStaffRepository.Add(Staff);
            _UoW.SaveChanges();

            var existingStaff = _appStaffRepository.GetStaffByDeparmentAndPersonIdWorking(Staff.DeparmentId, Staff.PersonId);
            Assert.IsNotNull(existingStaff);

            _appStaffRepository.Delete(existingStaff);

            _UoW.SaveChanges();

            var StaffEliminated = _appStaffRepository.GetStaffByDeparmentAndPersonIdWorking(Staff.DeparmentId, Staff.PersonId);

            Assert.IsNull(StaffEliminated);

        }

        [Test]
        public void UpdateStaff()
        {
            var fixture = new Fixture();
            var Staff = fixture.Build<StaffDto>().Without(p => p.StaffId).Without(p => p.MovedFired).Create();

            _appStaffRepository.Add(Staff);
            _UoW.SaveChanges();

            var existingStaff = _appStaffRepository.GetStaffByDeparmentAndPersonIdWorking(Staff.DeparmentId, Staff.PersonId);
            Assert.IsNotNull(existingStaff);
            Assert.AreNotEqual(existingStaff.StaffId, 0);
            Assert.AreEqual(existingStaff.PersonId, Staff.PersonId);
            DateTime firedDate = DateTime.UtcNow;

            existingStaff.MovedFired = firedDate;

            _appStaffRepository.Edit(existingStaff);

            _UoW.SaveChanges();

            var StaffUpdated = _appStaffRepository.GetAll().Where(x => x.StaffId == existingStaff.StaffId);

            Assert.IsNotNull(StaffUpdated.FirstOrDefault());

            Assert.AreEqual(StaffUpdated.FirstOrDefault().MovedFired, firedDate);


        }
    }
}
