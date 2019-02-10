using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.BusinessLogic.Staff.Validations
{
    public class StaffValidationAdd : IStaffValidationAdd
    {
        private readonly IStaffValidation Next;
        public StaffValidationAdd(IStaffValidation next)
        {
            Next = next;
        }

        public IResultContainer Validate(IStaff person)
        {
            return Next.Validate(person);
        }
    }

    public class StaffValidationUpdate : IStaffValidationUpdate
    {
        private readonly IStaffValidation Next;
        public StaffValidationUpdate(IStaffValidation next)
        {
            Next = next;
        }

        public IResultContainer Validate(IStaff person)
        {
            return Next.Validate(person);
        }
    }
}
