using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class AppConfigurationRepository : GenericRepository<AppConfiguration>, IAppConfigurationRepository
    {
        public AppConfigurationRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
