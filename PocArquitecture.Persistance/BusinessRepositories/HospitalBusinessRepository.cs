using PocArquitecture.Entities.BusinessLogic.Entities;
using PocArquitecture.Interfaces;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.BusinessRepositories
{

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

        public IResultObject<IHospital> GetHospitalByCode(string code)
        {
            IHospitalDto hospitalDto = _hospitalRepository.GetHospitalByCodeHospital(code);

            var hospital = new Hospital()
            {
                Address = hospitalDto.Address,
                Code = hospitalDto.Code,
                HospitalId = hospitalDto.HospitalId,
                Name = hospitalDto.Name,
                Phone = hospitalDto.Phone
            };

            return new ResultPersistanceObject<IHospital>(hospital);
        }

        public void Save(IHospital hospital)
        {
            HospitalDto hospitalDto = new HospitalDto()
            {
                Address = hospital.Address,
                Code = hospital.Code,
                Name = hospital.Name,
                Phone = hospital.Phone
            };

            this._hospitalRepository.Add(hospitalDto);

            this._uow.SaveChanges();

            return;

        }
    }
}
