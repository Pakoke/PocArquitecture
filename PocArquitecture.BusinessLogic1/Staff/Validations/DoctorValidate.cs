using PocArquitecture.BusinessLogic.Common;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System.Collections.Generic;

namespace PocArquitecture.BusinessLogic.Staff.Validations
{
    public class DoctorValidate : ValidationDecoratorTemplate
    {
        IStaffRepository _staffRepository;


        public DoctorValidate(IStaffRepository staffRepository, IStaffValidation next = null) : base(next)
        {
            _staffRepository = staffRepository;
        }
        
        protected override IList<IResult> ValidateTemplate(IStaff person)
        {
            if (person is IDoctor)
            {

                var idoctor = (IDoctor)person;
                IList<IResult> list = new List<IResult>();

                if (idoctor.NumOfYearsBlaBla < 10)
                    list.Add(new ResultValidation(EnumResultBL.ERROR_NUM_OF_YEARS_REQUIRED));

                if (person.Department.TypeOfDepartment != idoctor.MedicalSpeciality)
                    list.Add(new ResultValidation(EnumResultBL.ERROR_SPECIALITY_DEPARTMENT_MATCH_WITH_THE_DOCTOR_ONE));

                //create a filter with dni. and check if the doctor is working in other hospital currently
                var resultLH = _staffRepository.GetLaboralHistory(null);
                //list.Add(new ResultValidation(EnumResultBL.ERROR_SPECIALITY_DEPARTMENT_MATCH_WITH_THE_DOCTOR_ONE));

            }
            return null;
        }
    }
}
