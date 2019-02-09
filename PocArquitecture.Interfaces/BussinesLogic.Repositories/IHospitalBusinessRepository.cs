﻿using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Interfaces.BussinesLogic.Repositories
{
    public interface IHospitalBusinessRepository
    {
        IResultObject<IDepartment> GetDepartmentInThisHospital(string codeHospital, string codeDepartment);
    }
}