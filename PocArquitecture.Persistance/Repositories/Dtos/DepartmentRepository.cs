using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class DepartmentRepository : GenericRepository<DepartmentDto>, IDepartmentRepository
    {
        public DepartmentRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
