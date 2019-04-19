using PocArquitecture.Interfaces.Common;
using PocArquitecture.Interfaces.ICommon;
using System.Collections.Generic;

namespace PocArquitecture.Persistance
{

    public enum EnumResultPersistance
    {
        [Description("OK")]
        OK = 0,

        [Description("Department is required: {0}")]
        ERROR_UNEXPECTED_EXCEPTION,

        [Description("Hospital Result not found {0}")]
        ERROR_NOT_FOUND_HOSPITAL,

        [Description("Department Result not found {0}")]
        ERROR_NOT_FOUND_DEPARMENT
    }


    /// <summary>
    /// 
    /// </summary>
    public class ResultPersistance : AbstractResult<EnumResultPersistance>
    {
        public ResultPersistance(EnumResultPersistance x, params object[] para) : base(x, x.GetDescription(), para)
        { }

        public ResultPersistance() : base(EnumResultPersistance.OK, EnumResultPersistance.OK.GetDescription())
        { }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="X"></typeparam>
    public class ResultPersistanceObject<X> : AbstractResultObject<EnumResultPersistance, X>
    {
        public ResultPersistanceObject(EnumResultPersistance x, params object[] para) : base(x, x.GetDescription(), para)
        { }

        public ResultPersistanceObject(X item) : base(EnumResultPersistance.OK, item, EnumResultPersistance.OK.GetDescription())
        { }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="X"></typeparam>
    public class ResultPersistanceObjects<X> : AbstractResultObjects<EnumResultPersistance, X>
    {
        public ResultPersistanceObjects(EnumResultPersistance x, params object[] para) : base(x, x.GetDescription(), para)
        { }

        public ResultPersistanceObjects(IList<X> oItems) : base(EnumResultPersistance.OK, oItems, EnumResultPersistance.OK.GetDescription())
        { }
    }
}
