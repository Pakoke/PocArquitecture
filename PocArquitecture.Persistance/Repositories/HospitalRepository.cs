using PocArquitecture.Interfaces.Persistance.Entities;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;

namespace PocArquitecture.Persistance.Repositories
{
    public class HospitalRepository : GenericRepository<IHospital>, IHospitalRepository
    {
        public HospitalRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
