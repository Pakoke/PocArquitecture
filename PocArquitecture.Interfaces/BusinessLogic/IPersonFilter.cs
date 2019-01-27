using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System.Collections.Generic;

namespace PocArquitecture.Interfaces.BusinessLogic
{
    public interface IPersonFilter
    {
        IPeriodDates Joined { get; set; }
        string Dni { get; set; }
        string Department { get; set; }
        string Hostipal { get; set; }
    }
}
