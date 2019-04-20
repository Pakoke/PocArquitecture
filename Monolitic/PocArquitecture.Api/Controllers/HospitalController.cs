using Microsoft.AspNetCore.Mvc;
using PocArquitecture.Api.Model;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;
using PocArquitecture.Persistance.BusinessRepositories;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace PocArquitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        readonly IHospitalBusinessLogic hospitalBusinessLogic;

        public HospitalController(IHospitalBusinessLogic hospitalBusinessLogic)
        {
            this.hospitalBusinessLogic = hospitalBusinessLogic;
        }

        // 
        /// <summary>
        /// GET api/values
        /// </summary>
        /// <returns>The <see cref="ActionResult"/></returns>
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
        [SwaggerResponse(statusCode: 200, description: "The hospital is created", type: typeof(IEnumerable<StatusCodeResult>))]
        [SwaggerResponse(statusCode: 400, description: "User is not valid", type: typeof(IEnumerable<StatusCodeResult>))]
        [SwaggerResponse(statusCode: 404, description: "Request not valid", type: typeof(IEnumerable<StatusCodeResult>))]
        public IActionResult Post([FromBody] CreateHospitalModel hospitalModel)
        {
            if (ModelState.IsValid)
            {
                IResult result = null;
                IHospital hospital = new Hospital()
                {
                    Address = hospitalModel.Address,
                    Code = hospitalModel.Code,
                    Name = hospitalModel.Name,
                    Phone = hospitalModel.Phone
                };

                result = hospitalBusinessLogic.AddHospital(hospital);

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