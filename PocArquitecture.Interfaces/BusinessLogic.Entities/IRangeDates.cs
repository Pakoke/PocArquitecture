using System;
using System.Collections.Generic;
using System.Text;

namespace PocArquitecture.Interfaces.BusinessLogic.Entities
{
    public interface IRangeDates
    {
        DateTime? From { get; set; }
        DateTime? To { get; set; }
    }

}
