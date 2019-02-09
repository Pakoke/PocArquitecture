using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Entities.BusinessLogic.Entities
{
    public class PersonFilter : IPersonFilter
    {
        public IPeriodDates Joined { get ; set ; }
        public string Dni { get ; set ; }
        public string Department { get ; set ; }
        public string Hostipal { get ; set ; }
    }

    
}
