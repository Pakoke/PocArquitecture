using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System;
using System.Collections.Generic;

namespace PocArquitecture.Interfaces.BusinessLogic
{
    
    public interface IStaffFilter
    {
        IRangeDates Joined { get; set; }
        string Dni { get; set; }
        IList<string> NamesStaff { get; set; }
    }

    public interface IStaffBusinessLogic
    {
        IResult SaveStaff( IStaff person );
        IResultObjects<IStaff> GetStaff(IStaffFilter filter);
    }
}
