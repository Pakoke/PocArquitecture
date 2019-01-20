using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
