using System;
using System.Collections.Generic;
using System.Text;

namespace PocArquitecture.Interfaces.BusinessLogic.Entities
{
    public interface IHospital
    {
        string Code { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        List<IDepartment> Departments { get; set; }
    }
}
