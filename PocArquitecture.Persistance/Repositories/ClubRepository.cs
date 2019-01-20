using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class ClubRepository : GenericRepository<Club>, IClubRepository
    {
        public ClubRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
