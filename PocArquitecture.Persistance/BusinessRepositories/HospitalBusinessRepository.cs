using PocArquitecture.Interfaces;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Entities;
using System.Collections.Generic;

namespace PocArquitecture.Persistance.BusinessRepositories
{

    public class Hospital : IHospital
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<IDepartment> Departments { get; set; }
    }

    public class HospitalBusinessRepository : IHospitalBusinessRepository
    {
        private readonly IHospitalRepository _hospitalRepository;
        private readonly IDepartmentRepository _deparmentRepository;
        private readonly IGenericUoW _uow;

        public HospitalBusinessRepository(IGenericUoW uow, IHospitalRepository hospitalRepository, IDepartmentRepository departmentRepository)
        {
            _uow = uow;
            _hospitalRepository = hospitalRepository;
            _deparmentRepository = departmentRepository;
        }

        public IResultObject<IDepartment> GetDepartmentInThisHospital(string codeHospital, string codeDepartment)
        {
            IHospitalDto hospitalDto = _hospitalRepository.GetHospitalByCodeHospital(codeHospital);
            if (hospitalDto == null)
            {
                return new ResultPersistanceObject<IDepartment>(EnumResultPersistance.ERROR_NOT_FOUND_HOSPITAL, codeHospital);
            }

            IDepartmentDto departmentDto = _deparmentRepository.GetDepartmentByCodeDepartmentAndHospitalId(codeDepartment, hospitalDto.HospitalId);
            if (departmentDto == null)
            {
                return new ResultPersistanceObject<IDepartment>(EnumResultPersistance.ERROR_NOT_FOUND_DEPARMENT, codeHospital, codeDepartment);
            }

            IDepartment department = new Department()
            {
                Center = new Hospital()
                {
                    Name = hospitalDto.Name,
                    Address = hospitalDto.Address,
                    Code = hospitalDto.Code
                },
                Code = departmentDto.Code,
                DeparmentId = departmentDto.DepartmentId,
                Name = departmentDto.Name,
                TypeOfDepartment = departmentDto.TypeOfDepartment
            };

            return new ResultPersistanceObject<IDepartment>(department);
        }

        public void Save(IHospital staff)
        {
            throw new System.NotImplementedException();
        }
    }
}
