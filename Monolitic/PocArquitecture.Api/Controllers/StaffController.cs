using Microsoft.AspNetCore.Mvc;
using PocArquitecture.Entities.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BusinessLogic;
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
        /// <param name="dni">The value<see cref="string"/></param>
        /// <param name="codHospital">The value<see cref="string"/></param>
        /// <param name="codDepartment">The value<see cref="string"/></param>
        /// Sample UserLogin Request:
        ///
        ///     POST /Staff
        ///     {
        ///           "dni": "46258610T",
        ///           "codHospital": "pepa",
        ///           "codDepartment": "12",
        ///     }
        ///
        /// </remarks>
        /// <response code="200">The user is properly register</response>
        /// <response code="401">User is not valid</response>    
        [HttpPost]
        public IActionResult Post(string dni, string codHospital, string codDepartment)
        {
            if (ModelState.IsValid)
            {
                Doctor doctor = new Doctor();
                doctor.Dni = dni;
                doctor.Gender = "Male";
                doctor.BirthDate = DateTime.UtcNow.AddYears(-20);
                IResult result = null;
                //  result = staffBusinessLogic.AddStaffInHospital(doctor, codHospital, codDepartment);

                return Ok();
            }
            else
            {
                return NotFound();
            }
            /*
            Doctor doctor = new Doctor();
            doctor.Dni = dni;
            IResult result = null;
           // await Task.Run(() => {
                result = staffBusinessLogic.AddStaffInHospital(doctor, codHospital, codDepartment);
            //});

            if (result.ComputeResult().IsError())
                throw new System.Exception(result.Message());
                */
        }
    }
}