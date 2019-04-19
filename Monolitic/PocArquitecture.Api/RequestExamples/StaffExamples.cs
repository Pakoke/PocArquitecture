﻿using PocArquitecture.Api.Model;
using Swashbuckle.AspNetCore.Filters;

namespace PocArquitecture.Api.RequestExamples
{
    public class CreateStaffModelExample : IExamplesProvider<CreateStaffModel>
    {
        public CreateStaffModel GetExamples()
        {
            return new CreateStaffModel()
            {
                codeDepartment = "1A",
                codeHospital = "1D",
                dni = "46258610T",
                rol = "Doctor",
                numOfYearsBlaBla = 15,
                medicalSpeciality = "Type1"

            };
        }
    }
}
