using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Interfaces.Persistance.Repositories
{
    public interface IStaffRepository : IGenericRepository<StaffDto>
    {
        StaffDto GetStaffByDeparmentAndPersonIdWorking(int deparmentId, string personId);
    }

}
