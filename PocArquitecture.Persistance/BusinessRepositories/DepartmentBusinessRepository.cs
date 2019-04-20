using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;

namespace PocArquitecture.Persistance.BusinessRepositories
{
    public class Department : IDepartment
    {
        public int DeparmentId { get; set; }
        public string Code { get; set; }
        public IHospital Center { get; set; }
        public string Name { get; set; }
        public string TypeOfDepartment { get; set; }
    }

    public class DepartmentBusinessRepository : IDepartmentBusinessRepository
    {
        public void Save(IDepartment staff)
        {
            throw new System.NotImplementedException();
        }
    }
}
