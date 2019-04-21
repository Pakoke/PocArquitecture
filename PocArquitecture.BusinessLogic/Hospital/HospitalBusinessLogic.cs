using PocArquitecture.BusinessLogic.Common;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using System;

namespace PocArquitecture.BusinessLogic.Hospital
{
    public class HospitalBusinessLogic : IHospitalBusinessLogic
    {
        readonly IHospitalBusinessRepository hospitalBusinessRepository;

        public HospitalBusinessLogic(IHospitalBusinessRepository hospitalBusinessRepository)
        {
            this.hospitalBusinessRepository = hospitalBusinessRepository;
        }

        public IResult AddHospital(IHospital hospital)
        {

            if (hospital == null)
                return new ResultBusinessLogic();

            //Add validators
            /*
            IResult resultValidations = _validatorAdd.Validate(person);

            if (!resultValidations.ComputeResult().IsOk())
            {
                return resultValidations;
            }
            */

            try
            {
                this.hospitalBusinessRepository.Save(hospital);

            }
            catch (Exception e)
            {
                return new ResultBusinessLogic(EnumResultBL.ERROR_EXCEPTION_PERSISTANCE_HOSPITAL, e.Message);
            }

            return new ResultBusinessLogic(EnumResultBL.OK);
        }
    }
}
