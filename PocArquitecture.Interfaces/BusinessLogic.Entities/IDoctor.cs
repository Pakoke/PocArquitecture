
namespace PocArquitecture.Interfaces.BusinessLogic.Entities
{
    public interface IDoctor : IOperationsStaff
    {
        int NumOfYearsBlaBla { get; set; }
        string MedicalSpeciality { get; set; }
    }
}