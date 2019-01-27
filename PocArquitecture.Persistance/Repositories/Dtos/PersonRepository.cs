using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class PersonRepository : GenericRepository<PersonDto>, IPersonRepository
    {
        public PersonRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
