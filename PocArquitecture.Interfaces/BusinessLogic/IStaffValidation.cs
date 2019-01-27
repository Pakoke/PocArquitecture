using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Interfaces.BusinessLogic
{
    public interface IStaffValidation
    {
        IResultContainer Validate(IStaff person);
    }
}
 