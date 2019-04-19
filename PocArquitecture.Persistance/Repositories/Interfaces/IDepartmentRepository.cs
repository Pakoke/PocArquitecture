using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Interfaces.Persistance.Repositories
{
    public interface IDepartmentRepository : IGenericRepository<DepartmentDto>
    {
        IDepartmentDto GetDepartmentByCodeDepartmentAndHospitalId(string codeDepartment, int codeHospital);
    }
}
