using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Entities.BusinessLogic.Entities
{
    public class Department : IDepartment
    {
        public int DeparmentId { get; set; }
        public string Code { get; set; }
        public IHospital Center { get; set; }
        public string Name { get; set; }
        public string TypeOfDepartment { get; set; }
    }
}
