using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;
using System.Linq;

namespace PocArquitecture.Persistance.Repositories
{
    public class DepartmentRepository : GenericRepository<DepartmentDto>, IDepartmentRepository
    {
        public DepartmentRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }

        public IDepartmentDto GetDepartmentByCodeDepartmentAndHospitalId(string codeDepartment, int hospitalId)
        {
            return this.GetAll().Where(x => x.Code == codeDepartment && x.HospitalId == hospitalId).FirstOrDefault();
        }
    }
}
