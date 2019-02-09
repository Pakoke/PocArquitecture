using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Interfaces.BussinesLogic.Repositories
{
    public interface IStaffBusinessRepository
    {
        IResult Save(IStaff staff);

        IResultObjects<ILaboralHistory> GetLaboralHistory(IPersonFilter filter);
    }
}
