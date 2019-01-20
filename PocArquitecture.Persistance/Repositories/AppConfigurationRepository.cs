using PocArquitecture.Interfaces.Persistance.Entities;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class AppConfigurationRepository : GenericRepository<IAppConfiguration>, IAppConfigurationRepository
    {
        public AppConfigurationRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
