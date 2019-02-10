using PocArquitecture.Interfaces;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocArquitecture.Persistance.BusinessRepositories
{

    public class Department : IDepartment
    {
        public int DeparmentId { get ; set ; }
        public string Code { get ; set ; }
        public IHospital Center { get ; set ; }
        public string Name { get ; set ; }
        public string TypeOfDepartment { get ; set ; }
    }

    public class Hospital : IHospital
    {
        public string Code { get ; set ; }
        public string Name { get ; set ; }
        public string Address { get ; set ; }
        public List<IDepartment> Departments { get ; set ; }
    }

    public class HospitalBusinessRepository : IHospitalBusinessRepository
    {
        private readonly IHospitalRepository _hospitalRepository;
        private readonly IGenericUoW _uow;

        public HospitalBusinessRepository(IGenericUoW uow, IHospitalRepository hospitalRepository)
        {
            _uow = uow;
            _hospitalRepository = hospitalRepository;
        }

        public IResultObject<IDepartment> GetDepartmentInThisHospital(string codeHospital, string codeDepartment)
        {
            IDepartment department = new Department();
            IHospital hospital = new Hospital();

            hospital.Code = codeHospital;
            department.Code = codeDepartment;
            department.TypeOfDepartment = "Type1";

            department.Center = hospital;
            department.DeparmentId = 1;

            return new ResultPersistanceObject<IDepartment>(department);
        }
    }
}
