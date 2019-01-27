using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Entities.BusinessLogic.Entities
{
    public class Doctor : Staff, IDoctor
    {
        public int NumOfYearsBlaBla { get ; set ; }
        public string MedicalSpeciality { get ; set ; }
    }
}
