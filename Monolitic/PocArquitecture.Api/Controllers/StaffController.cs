using Microsoft.AspNetCore.Mvc;
using PocArquitecture.Api.Model;
using PocArquitecture.Entities.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System;

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
        /// <response code="200">The user is properly register</response>
        /// <response code="401">User is not valid</response>    
        [HttpPost]
        //[SwaggerRequestExample(typeof(CreateStaffModel), typeof(CreateStaffModelExample))]
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