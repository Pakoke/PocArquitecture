using PocArquitecture.BusinessLogic.Common;
using PocArquitecture.Entities.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using System;
using System.Collections.Generic;

namespace PocArquitecture.BusinessLogic.Staff.Validations
{
    public class DoctorValidate : ValidationDecoratorTemplate
    {
        IStaffBusinessRepository _staffRepository;


        public DoctorValidate(IStaffBusinessRepository staffRepository, IStaffValidation next = null) : base(next)
        {
            _staffRepository = staffRepository;
        }

        protected override IList<IResult> ValidateTemplate(IStaff person)
        {
            IList<IResult> list = new List<IResult>();
            if (person is IDoctor)
            {

                var idoctor = (IDoctor)person;
                

                if (idoctor.NumOfYearsBlaBla < 10)
                    list.Add(new ResultValidation(EnumResultBL.ERROR_NUM_OF_YEARS_REQUIRED));

                if (person.Department.TypeOfDepartment != idoctor.MedicalSpeciality)
                    list.Add(new ResultValidation(EnumResultBL.ERROR_SPECIALITY_DEPARTMENT_MATCH_WITH_THE_DOCTOR_ONE));

                //create a filter with dni. and check if the doctor is working in other hospital currently

                //PersonFilter filter = new PersonFilter() { Dni = person.Dni};
                //var resultLH = _staffRepository.GetLaboralHistory(null);
                //   list.Add(new ResultValidation(EnumResultBL.ERROR_SPECIALITY_DEPARTMENT_MATCH_WITH_THE_DOCTOR_ONE));
            }
            return list;
        }
    }
}
