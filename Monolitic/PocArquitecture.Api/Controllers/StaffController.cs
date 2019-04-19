using Microsoft.AspNetCore.Mvc;
using PocArquitecture.Api.Model;
using PocArquitecture.Entities.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace PocArquitecture.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        readonly IStaffBusinessLogic staffBusinessLogic;

        public StaffController(IStaffBusinessLogic staffBusinessLogic)
        {
            this.staffBusinessLogic = staffBusinessLogic;
        }


        // 
        /// <summary>
        /// GET api/values
        /// </summary>
        /// <returns>The <see cref="ActionResult{IEnumerable{string}}"/></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // 
        /// <summary>
        /// POST api/values
        /// </summary>
        /// <param name="personModel">All the info required to create a new staff in the hospital</param>
        [HttpPost]
        [SwaggerResponse(statusCode: 200, description: "The staff is properly register", type: typeof(IEnumerable<StatusCodeResult>))]
        [SwaggerResponse(statusCode: 400, description: "User is not valid", type: typeof(IEnumerable<StatusCodeResult>))]
        [SwaggerResponse(statusCode: 404, description: "Request not valid", type: typeof(IEnumerable<StatusCodeResult>))]
        public IActionResult Post([FromBody] CreateStaffModel personModel)
        {
            if (ModelState.IsValid)
            {
                IResult result = null;
                IStaff person = null;
                if (personModel.rol == "Doctor")
                {
                    var doctor = new Doctor();
                    doctor.Dni = personModel.dni;
                    doctor.Gender = "Male";
                    doctor.BirthDate = DateTime.UtcNow.AddYears(-20);
                    doctor.MedicalSpeciality = personModel.medicalSpeciality;
                    doctor.NumOfYearsBlaBla = personModel.numOfYearsBlaBla;
                    person = doctor;
                }
                else
                {
                    var nurse = new Nurse();
                    nurse.Dni = personModel.dni;
                    nurse.Gender = "Female";
                    nurse.BirthDate = DateTime.UtcNow.AddYears(-20);
                    person = nurse;
                }


                result = staffBusinessLogic.AddStaffInHospital(person, personModel.codeHospital, personModel.codeDepartment);
                if (result.ComputeResult().IsOk())
                {
                    return Ok();
                }
                else
                {
                    return BadRequest(result.Message());
                }
            }
            else
            {
                return NotFound();
            }
        }

    }
}