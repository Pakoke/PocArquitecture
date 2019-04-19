using PocArquitecture.BusinessLogic.Common;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using System;

namespace PocArquitecture.BusinessLogic.Staff
{
    public class StaffBusinessLogic : IStaffBusinessLogic
    {
        readonly IStaffValidationAdd _validatorAdd;
        readonly IStaffValidationUpdate _validatorUpdate;
        readonly IStaffBusinessRepository _staffRepository;
        readonly IHospitalBusinessRepository _hospitalBusinessRepository;

        public StaffBusinessLogic(IStaffValidationAdd validator,
                                  IStaffValidationUpdate validatorUpdate,
                                  IStaffBusinessRepository staffRepository,
                                  IHospitalBusinessRepository hospitalBusinessRepository)
        {
            _validatorAdd = validator;
            _validatorUpdate = validatorUpdate;
            _staffRepository = staffRepository;
            _hospitalBusinessRepository = hospitalBusinessRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <param name="codeHospital"></param>
        /// <param name="codeDepartment"></param>
        /// <returns></returns>
        public IResult AddStaffInHospital(IStaff person, string codeHospital, string codeDepartment)
        {
            var resDepartment = _hospitalBusinessRepository.GetDepartmentInThisHospital(codeHospital, codeDepartment);
            if (!resDepartment.ComputeResult().IsOk())
                return resDepartment;

            person.Department = resDepartment.GetItem();

            IResult resultValidations = _validatorAdd.Validate(person);

            if (!resultValidations.ComputeResult().IsOk())
            {
                return resultValidations;
            }

            try
            {
                _staffRepository.Save(person);

            }
            catch (Exception e)
            {
                return new ResultBusinessLogic(EnumResultBL.ERROR_EXCEPTION_PERSISTANCE_STAFF, e.Message);
            }

            return new ResultBusinessLogic(EnumResultBL.OK);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public IResult Update(IStaff person)
        {
            IResult resultValidations = _validatorUpdate.Validate(person);

            if (!resultValidations.ComputeResult().IsOk())
            {
                return resultValidations;
            }

            try
            {
                _staffRepository.Save(person);

            }
            catch (Exception e)
            {
                return new ResultBusinessLogic(EnumResultBL.ERROR_EXCEPTION_PERSISTANCE_STAFF, e.Message);
            }
            return new ResultBusinessLogic(EnumResultBL.OK);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public IResultObjects<ILaboralHistory> GetStaff(IPersonFilter filter)
        {
            throw new NotImplementedException();
        }

        IResultObjects<IStaff> IStaffBusinessLogic.GetStaff(IPersonFilter filter)
        {
            throw new NotImplementedException();
        }

        public IResultObjects<ILaboralHistory> GetLaboralHistory(IPersonFilter filter)
        {
            throw new NotImplementedException();
        }

    }
}
