﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PocArquitecture.Interfaces.BusinessLogic.Entities
{
    public interface IPeriodDates
    {
        DateTime? From { get; set; }
        DateTime? To { get; set; }
    }

}
