using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocArquitecture.Interfaces.BusinessLogic
{
    public interface IPatientBusinessLogic
    {
        IResult AddPatientInHospital(IPatient person, IHospital hospital);
        IResultObjects<IMedicalHistory> GetMedicalHistory(IPersonFilter filter);
    }
}
