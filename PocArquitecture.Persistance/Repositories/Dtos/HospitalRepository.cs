using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;
using System.Linq;

namespace PocArquitecture.Persistance.Repositories
{
    public class HospitalRepository : GenericRepository<HospitalDto>, IHospitalRepository
    {
        public HospitalRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }

        public IHospitalDto GetHospitalByCodeHospital(string codeHospital)
        {
            return this.GetAll().Where(h => h.Code == codeHospital).FirstOrDefault();
        }
    }
}
