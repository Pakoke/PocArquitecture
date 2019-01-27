﻿using PocArquitecture.Interfaces.Persistance.Entities;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;

namespace PocArquitecture.Persistance.Repositories
{
    public class PatientRepository : GenericRepository<IPatient>, IPatientRepository
    {
        public PatientRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
