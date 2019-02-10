using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Interfaces.BusinessLogic
{

    public interface IStaffBusinessLogic
    {
        IResult AddStaffInHospital(IStaff person, string codeHospital, string codeDepartment);
        IResult Update(IStaff person);
        IResultObjects<IStaff> GetStaff(IPersonFilter filter);
        IResultObjects<ILaboralHistory> GetLaboralHistory(IPersonFilter filter);
    }

}
