using PocArquitecture.BusinessLogic.Common;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using System;

namespace PocArquitecture.BusinessLogic.Department
{
    public class DepartmentBusinessLogic : IDepartmentBusinessLogic
    {
        readonly IDepartmentBusinessRepository departmentBusinessRepository;
        readonly IHospitalBusinessRepository hospitalBusinessRepository;

        public DepartmentBusinessLogic(IDepartmentBusinessRepository departmentBusinessRepository, IHospitalBusinessRepository hospitalBusinessRepository)
        {
            this.departmentBusinessRepository = departmentBusinessRepository;
            this.hospitalBusinessRepository = hospitalBusinessRepository;
        }

        public IResult AddDeparment(IDepartment department)
        {
            if (department == null)
                return new ResultBusinessLogic(EnumResultBL.ERROR_DEPARTMENT_REQUIRED);

            //Add validators
            //Check that the hospital exist searching by the code 
            /*
            IResult resultValidations = _validatorAdd.Validate(person);

            if (!resultValidations.ComputeResult().IsOk())
            {
                return resultValidations;
            }
            */

            var hospitalResult = this.hospitalBusinessRepository.GetHospitalByCode(department.Center.Code);

            if (hospitalResult.ComputeResult().IsError())
                return new ResultBusinessLogic(EnumResultBL.ERROR_HOSPITAL_NOT_VALID);

            department.Center.HospitalId = hospitalResult.GetItem().HospitalId;

            try
            {
                this.departmentBusinessRepository.Save(department);

            }
            catch (Exception e)
            {
                return new ResultBusinessLogic(EnumResultBL.ERROR_EXCEPTION_PERSISTANCE_DEPARTMENT, e.Message);
            }

            return new ResultBusinessLogic(EnumResultBL.OK);
        }
    }
}
