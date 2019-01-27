using System;
using System.Collections.Generic;
using System.Text;

namespace PocArquitecture.Interfaces.BusinessLogic.Entities
{
    public interface IDepartment
    {
        int Id { get; set; }
        string Code { get; set; }
        IHospital Center { get; set; }
        string Name { get; set; }
        string TypeOfDepartment { get; set; }    
    }
}
