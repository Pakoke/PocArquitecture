using PocArquitecture.Core.Serilog;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.Common;
using Serilog;
using System.Collections.Generic;

namespace PocArquitecture.BusinessLogic.Staff.Validations
{
    public abstract class ValidationDecoratorTemplate : IStaffValidation
    {
        readonly IStaffValidation Next;

        static readonly ILogger Log = Serilog.Log.ForContext<ValidationDecoratorTemplate>();

        public ValidationDecoratorTemplate(IStaffValidation next = null)
        {
            Next = next;
        }

        public IResultContainer Validate(IStaff person)
        {

            IList<IResult> resultCurrent = ValidateTemplate(person);


            if (Next != null)
            {
                Log.Debug("Validation Staff Start", SerilogStringTemplates.ValidationStaffMessageTemplate, Next.GetType(), person?.Dni);
                var resultNext = Next.Validate(person);
                var listToIt = resultNext.ResultDetails;

                if (listToIt != null)
                {
                    foreach (var aux in listToIt)
                    {
                        resultCurrent.Add(aux);

                        Log.Debug("Validation Staff Ends", SerilogStringTemplates.ValidationStaffMessageTemplate, Next.GetType().ToString(), person?.Dni, aux.Message());
                    }
                }
            }
            return new ResultList(resultCurrent);
        }

        protected abstract IList<IResult> ValidateTemplate(IStaff person);

    }

}
