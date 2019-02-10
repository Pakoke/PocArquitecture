using Microsoft.AspNetCore.Mvc;
using PocArquitecture.Entities.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System;

namespace PocArquitecture.Api.Controllers
{

    public class StaffJson
    {
        public string dni { get; set; }
        public string rol { get; set; }
        public int numOfYearsBlaBla { get; set; }
        public string medicalSpeciality { get; set; }
    }

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
        /// <param name="dni">The value<see cref="string"/></param>
        /// <param name="codHospital">The value<see cref="string"/></param>
        /// <param name="codDepartment">The value<see cref="string"/></param>
        /// Sample UserLogin Request:
        ///
        ///     POST /StaffJson
        ///     {
        ///           "dni": "46258610T",
        ///           "rol": "Doctor",
        ///           "numOfYearsBlaBla": "15",
        ///           "medicalSpeciality": "Type1",
        ///     }
        ///
        /// </remarks>
        /// <response code="200">The user is properly register</response>
        /// <response code="401">User is not valid</response>    
        [HttpPost]
        public IActionResult Post([FromBody] StaffJson personJson, string codHospital, string codDepartment)
        {
            if (ModelState.IsValid)
            {
                IResult result = null;
                IStaff person = null;
                if (personJson.rol == "Doctor")
                {
                    var doctor = new Doctor();
                    doctor.Dni = personJson.dni;
                    doctor.Gender = "Male";
                    doctor.BirthDate = DateTime.UtcNow.AddYears(-20);
                    doctor.MedicalSpeciality = personJson.medicalSpeciality;
                    doctor.NumOfYearsBlaBla = personJson.numOfYearsBlaBla;
                    person = doctor;
                }
                else
                {
                    var nurse = new Nurse();
                    nurse.Dni = personJson.dni;
                    nurse.Gender = "Female";
                    nurse.BirthDate = DateTime.UtcNow.AddYears(-20);
                    person = nurse;
                }


                result = staffBusinessLogic.AddStaffInHospital(person, codHospital, codDepartment);
                if (result.ComputeResult().IsOk())
                {
                    return Ok();
                }
                else
                {
                    throw new Exception(result.Message());                 
                }
            }
            else
            {
                return NotFound();
            }
        }
        
    }
}