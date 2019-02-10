using PocArquitecture.BusinessLogic.Common;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System.Collections.Generic;

namespace PocArquitecture.BusinessLogic.Staff.Validations
{
    public class StaffAsPersonValidate : ValidationDecoratorTemplate
    {

        public StaffAsPersonValidate(IStaffValidation next = null) : base(next)
        {

        }


        protected override IList<IResult> ValidateTemplate(IStaff person)
        {
            IList<IResult> list = new List<IResult>();

            if (string.IsNullOrWhiteSpace(person.Dni))
                list.Add(new ResultValidation(EnumResultBL.ERROR_DNI_REQUIRED));

            return list;
        }
    }
}
