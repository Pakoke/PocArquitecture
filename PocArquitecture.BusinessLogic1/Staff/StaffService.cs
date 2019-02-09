using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.Repository;
using System;

namespace PocArquitecture.BusinessLogic.Staff
{

    public class StaffService : IStaffBusinessLogic
    {
        readonly IStaffValidation _validator;
        readonly IStaffRepository _staffRepository;
        readonly IHospitalRepository _hospitalRepository;

        public StaffService(IStaffValidation validator, IStaffRepository staffRepository, IHospitalRepository hospitalRepository)
        {
            _validator = validator;
            _staffRepository = staffRepository;
            _hospitalRepository = hospitalRepository;
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
            var resDepartment = _hospitalRepository.GetDepartmentInThisHospital(codeHospital, codeDepartment);
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
