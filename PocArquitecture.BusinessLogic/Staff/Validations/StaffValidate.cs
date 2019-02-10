using PocArquitecture.BusinessLogic.Common;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System.Collections.Generic;

namespace PocArquitecture.BusinessLogic.Staff.Validations
{
    public class StaffValidate : ValidationDecoratorTemplate
    {

        public StaffValidate(IStaffValidation next = null) : base(next)
        {

        }


        protected override IList<IResult> ValidateTemplate(IStaff person)
        {
            IList<IResult> list = new List<IResult>();

            if (person.Department == null || person.Department.DeparmentId == 0)
                list.Add(new ResultValidation(EnumResultBL.ERROR_DEPARTMENT_REQUIRED));

            return list;
        }
    }




}
