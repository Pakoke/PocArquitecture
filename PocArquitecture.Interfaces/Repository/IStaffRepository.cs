using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Interfaces.Repository
{
    public interface IStaffRepository
    {
        IResult Save(IStaff staff);
        IResultObjects<ILaboralHistory> GetLaboralHistory(IPersonFilter filter);
    }

    public interface IHospitalRepository
    {
        IResultObject<IDepartment> GetDepartmentInThisHospital(string codeHospital, string codeDepartment);
    }
}
