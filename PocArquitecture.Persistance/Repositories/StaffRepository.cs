using PocArquitecture.Interfaces.Persistance.Entities;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;

namespace PocArquitecture.Persistance.Repositories
{
    public class StaffRepository : GenericRepository<IStaff>, IStaffRepository
    {
        public StaffRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
