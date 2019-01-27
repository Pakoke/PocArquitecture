using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System.Collections.Generic;

namespace PocArquitecture.Interfaces.BusinessLogic
{

    public interface IPersonFilter
    {
        IRangeDates Joined { get; set; }
        string Dni { get; set; }
        IList<string> NamesStaff { get; set; }
        string Hostipal { get; set; }
    }

    public interface IStaffBusinessLogic
    {
        IResult AddStaffInHospital(IStaff person, IHospital hospital);
        IResult Update(IStaff person);
        IResultObjects<IStaff> GetStaff(IPersonFilter filter);
    }

    public interface IPatientBusinessLogic
    {
        IResult AddPatientInHospital(IPatient person, IHospital hospital);
        IResultObjects<IMedicalHistory> GetMedicalHistory(IPersonFilter filter);
    }


    
}
