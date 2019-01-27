﻿using PocArquitecture.Interfaces.Persistance.Entities;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;

namespace PocArquitecture.Persistance.Repositories
{
    public class DepartmentRepository : GenericRepository<IDepartment>, IDepartmentRepository
    {
        public DepartmentRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }
    }
}
