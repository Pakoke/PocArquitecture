using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System;

namespace PocArquitecture.Entities.BusinessLogic.Entities
{
    public class PeriodDates : IPeriodDates
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
