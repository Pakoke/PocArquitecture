using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Interfaces.BusinessLogic
{
    public interface IHospitalBusinessLogic
    {
        IResult AddHospital(IHospital hospital);
    }
}
