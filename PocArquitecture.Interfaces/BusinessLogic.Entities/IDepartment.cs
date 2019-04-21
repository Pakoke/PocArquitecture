namespace PocArquitecture.Interfaces.BusinessLogic.Entities
{
    public interface IDepartment
    {
        int DeparmentId { get; set; }
        string Code { get; set; }
        IHospital Center { get; set; }
        string Name { get; set; }
        string TypeOfDepartment { get; set; }
    }
}
