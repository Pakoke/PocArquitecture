using PocArquitecture.Interfaces;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using PocArquitecture.Interfaces.Common;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Entities;
using System;
using System.Collections.Generic;

namespace PocArquitecture.Persistance.BusinessRepositories
{
    public class StaffBusinessRepository : IStaffBusinessRepository
    {
        private readonly IStaffRepository staffRepository;
        private readonly IPatientRepository patientRepository;
        private readonly IPersonRepository personRepository;
        private readonly IGenericUoW uow;

        public StaffBusinessRepository(IStaffRepository staffRepository, IPatientRepository patientRepository, IPersonRepository personRepository, IGenericUoW uow)
        {
            this.staffRepository = staffRepository;
            this.patientRepository = patientRepository;
            this.personRepository = personRepository;
            this.uow = uow;
        }
        public IResultObjects<ILaboralHistory> GetLaboralHistory(IPersonFilter filter)
        {
            return new ResultPersistanceObjects<ILaboralHistory>(EnumResultPersistance.OK,new List<ILaboralHistory>());
        }

        public void Save(IStaff staff)
        {

            var personExist = new PersonDto() { Dni = staff.Dni };

            personExist = personRepository.GetById(personExist.Dni);

            if (personExist == null)
            {
                personExist = new PersonDto()
                {
                    BirthDate = staff.BirthDate,
                    Dni = staff.Dni,
                    FamilyName = staff.FamilyName,
                    Gender = staff.Gender,
                    GivenName = staff.GiveName,
                };
                personRepository.Add(personExist);
            }

            var staffDto = new StaffDto()
            {
                PersonId = personExist.Dni,
                Joined = DateTime.UtcNow
            };

            if (staff is IDoctor)
            {
                staffDto.StaffId = (int)TypeStaffEnum.Doctor;
            }
            if (staff is INurse)
            {
                staffDto.StaffId = (int)TypeStaffEnum.Nurse;

            }

            staffRepository.Add(staffDto);

            uow.SaveChanges();

            return;

        }
    }



}
