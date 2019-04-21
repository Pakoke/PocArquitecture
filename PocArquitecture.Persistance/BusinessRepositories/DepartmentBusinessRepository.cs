using PocArquitecture.Interfaces;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.BusinessRepositories
{

    public class DepartmentBusinessRepository : IDepartmentBusinessRepository
    {
        private readonly IGenericUoW _uow;
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentBusinessRepository(IGenericUoW uow, IDepartmentRepository departmentRepository)
        {
            this._uow = uow;
            this._departmentRepository = departmentRepository;
        }

        public void Save(IDepartment staff)
        {
            DepartmentDto departmentDto = new DepartmentDto()
            {
                Code = staff.Code,
                Name = staff.Name,
                TypeOfDepartment = staff.TypeOfDepartment,
                HospitalId = staff.Center.HospitalId
            };

            this._departmentRepository.Add(departmentDto);

            this._uow.SaveChanges();

            return;
        }
    }
}
