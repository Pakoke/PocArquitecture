using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class StaffTypeRepository : GenericRepository<StaffTypeDto>, IStaffTypeRepository
    {
        public StaffTypeRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
