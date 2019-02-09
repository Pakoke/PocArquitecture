using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{

    public class StaffRepositoryHL : PocArquitecture.Interfaces.Repository.IStaffRepository
    {
        readonly IStaffRepository _repository;

        public StaffRepositoryHL(IStaffRepository repository)
        {
            _repository = repository;
        }

        public IResultObjects<ILaboralHistory> GetLaboralHistory(IPersonFilter filter)
        {
            throw new System.NotImplementedException();
        }

        public IResult Save(IStaff staff)
        {
            throw new System.NotImplementedException();
        }
    }

    public class StaffRepository : GenericRepository<StaffDto>, IStaffRepository
    {
        public StaffRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }


    public class HospitalRepositoryHL : PocArquitecture.Interfaces.Repository.IHospitalRepository
    {
        public IResultObject<IDepartment> GetDepartmentInThisHospital(string codeHospital, string codeDepartment)
        {
        return null;
        }
    }
}
