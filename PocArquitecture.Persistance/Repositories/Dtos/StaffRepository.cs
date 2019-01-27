using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class StaffRepository : GenericRepository<StaffDto>, IStaffRepository
    {
        public StaffRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
