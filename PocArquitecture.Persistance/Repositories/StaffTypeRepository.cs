using PocArquitecture.Interfaces.Persistance.Entities;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;

namespace PocArquitecture.Persistance.Repositories
{
    public class StaffTypeRepository : GenericRepository<IStaffType>, IStaffTypeRepository
    {
        public StaffTypeRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
