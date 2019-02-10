using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Entities;
using System.Linq;

namespace PocArquitecture.Persistance.Repositories
{


    public class StaffRepository : GenericRepository<StaffDto>, IStaffRepository
    {
        public StaffRepository(PocArquitectureContext dbContext) : base(dbContext)
        {
        }

        public IResultObjects<ILaboralHistory> GetLaboralHistory(IPersonFilter filter)
        {
            throw new System.NotImplementedException();
        }

        public StaffDto GetStaffByDeparmentAndPersonIdWorking(int deparmentId, string personId)
        {
            return this._objectSet.FirstOrDefault(s => s.DeparmentId == deparmentId && s.PersonId == personId && s.MovedFired == null);
        }
    }
}
