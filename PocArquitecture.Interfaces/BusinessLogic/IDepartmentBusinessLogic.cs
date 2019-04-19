using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Interfaces.BusinessLogic
{
    public interface IDepartmentBusinessLogic
    {
        IResult AddDeparment(IDepartment department);
    }
}
