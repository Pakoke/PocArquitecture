using PocArquitecture.Interfaces.Common;
using PocArquitecture.Interfaces.ICommon;

namespace PocArquitecture.BusinessLogic.Common
{
    public enum EnumResultBL
    {
        [Description("OK")]
        OK = 0,

        [Description("Department is requiered")]
        ERROR_DEPARTMENT_REQUIRED,

        [Description("Department is requiered")]
        ERROR_DNI_REQUIRED,

        [Description("Minimum amount of Years requiered is not passed")]
        ERROR_NUM_OF_YEARS_REQUIRED,

        [Description("Medical speciality of the doctor doesn´t match with speciality  of the Department")]
        ERROR_SPECIALITY_DEPARTMENT_MATCH_WITH_THE_DOCTOR_ONE,

        [Description("ERROR WHEN SAVING DATA OF A MEMBER OF STAFF")]
        ERROR_EXCEPTION_PERSISTANCE_STAFF


    }

    public class ResultValidation : AbstractResult<EnumResultBL>
    {
        public ResultValidation(EnumResultBL x, params object[] para) : base(x, x.GetDescription(), para)
        { }

        public ResultValidation() : base(EnumResultBL.OK, EnumResultBL.OK.GetDescription())
        { }
    }

    public class ResultBusinessLogic : AbstractResult<EnumResultBL>
    {
        public ResultBusinessLogic(EnumResultBL x, params object[] para) : base(x, x.GetDescription(), para)
        { }

        public ResultBusinessLogic() : base(EnumResultBL.OK, EnumResultBL.OK.GetDescription())
        { }
    }
}
