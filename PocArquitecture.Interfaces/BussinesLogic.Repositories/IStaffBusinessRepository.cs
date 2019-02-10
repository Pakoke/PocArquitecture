using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Interfaces.BussinesLogic.Repositories
{
    public interface IStaffBusinessRepository
    {
        void Save(IStaff staff);

        IResultObjects<ILaboralHistory> GetLaboralHistory(IPersonFilter filter);
    }
}
