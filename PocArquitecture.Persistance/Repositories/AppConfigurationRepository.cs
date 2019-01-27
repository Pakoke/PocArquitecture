﻿using PocArquitecture.Interfaces.Persistance.Entities;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;

namespace PocArquitecture.Persistance.Repositories
{
    public class AppConfigurationRepository : GenericRepository<IAppConfiguration>, IAppConfigurationRepository
    {
        public AppConfigurationRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
