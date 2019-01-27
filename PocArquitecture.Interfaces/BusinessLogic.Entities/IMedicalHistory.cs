using System;

namespace PocArquitecture.Interfaces.BusinessLogic.Entities
{
    public interface IMedicalHistory
    {
        IPatient Patient { get; set; }
        IOperationsStaff AttendedBy { get; set; }
   
    
    }
}
