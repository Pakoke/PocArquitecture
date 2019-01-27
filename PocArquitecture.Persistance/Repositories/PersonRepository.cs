using PocArquitecture.Interfaces.Persistance.Entities;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;

namespace PocArquitecture.Persistance.Repositories
{
    public class PersonRepository : GenericRepository<IPerson>, IPersonRepository
    {
        public PersonRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
