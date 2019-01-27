using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class PatientRepository : GenericRepository<PatientDto>, IPatientRepository
    {
        public PatientRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
