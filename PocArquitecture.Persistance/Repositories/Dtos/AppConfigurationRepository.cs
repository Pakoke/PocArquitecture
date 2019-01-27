using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Repositories
{
    public class AppConfigurationRepository : GenericRepository<AppConfigurationDto>, IAppConfigurationRepository
    {
        public AppConfigurationRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
