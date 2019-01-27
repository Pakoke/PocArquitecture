using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.Common;
using System.Collections.Generic;

namespace PocArquitecture.BusinessLogic.Staff.Validations
{
    public abstract class ValidationDecoratorTemplate : IStaffValidation
    {
        readonly IStaffValidation Next;

        public ValidationDecoratorTemplate(IStaffValidation next = null)
        {
            Next = next;
        }

        public IResultContainer Validate(IStaff person)
        {

            IList<IResult> resultCurrent = ValidateTemplate(person);

            if (Next != null)
            {
                var resultNext = Next.Validate(person);
                var listToIt = resultNext.ResultDetails;

                foreach (var aux in listToIt)
                {
                    resultCurrent.Add(aux);
                }
            }
            return new ResultList(resultCurrent);
        }

        protected abstract IList<IResult> ValidateTemplate(IStaff person);

    }


   


}
