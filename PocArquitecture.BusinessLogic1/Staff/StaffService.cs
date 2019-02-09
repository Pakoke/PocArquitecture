using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using System;

namespace PocArquitecture.BusinessLogic.Staff
{
    public class StaffService : IStaffBusinessLogic
    {
        readonly IStaffValidation _validator;
        readonly IStaffBusinessRepository _staffRepository;
        readonly IHospitalBusinessRepository _hospitalBusinessRepository;

        public StaffService(IStaffValidation validator, IStaffBusinessRepository staffRepository, IHospitalBusinessRepository hospitalBusinessRepository)
        {
            _validator = validator;
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

            IResult resultValidations = _validator.Validate(person);

            if (!resultValidations.ComputeResult().IsOk())
            {
                return resultValidations;
            }

            person.Department = resDepartment.GetItem();

            IResult resultSave = _staffRepository.Save(person);
            return resultSave;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public IResult Update(IStaff person)
        {
            IResult resultValidations = _validator.Validate(person);

            if (!resultValidations.ComputeResult().IsOk())
            {
                return resultValidations;
            }

            IResult resultSave = _staffRepository.Save(person);
            return resultSave;
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
