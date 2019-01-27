using System;
using System.Collections.Generic;
using System.Text;

namespace PocArquitecture.Interfaces.BusinessLogic.Entities
{
    public interface ILaboralHistory
    {
        IStaff Staff { get; set; }
        IDepartment Department { get; set; }
        IPeriodDates Period { get; set; }
    }
}
