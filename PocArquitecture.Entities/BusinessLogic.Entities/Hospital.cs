using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System.Collections.Generic;

namespace PocArquitecture.Entities.BusinessLogic.Entities
{
    public class Hospital : IHospital
    {
        public int HospitalId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<IDepartment> Departments { get; set; }
        public string Phone { get; set; }
    }
}
