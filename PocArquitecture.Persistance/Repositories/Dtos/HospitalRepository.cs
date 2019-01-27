using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class HospitalRepository : GenericRepository<HospitalDto>, IHospitalRepository
    {
        public HospitalRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
