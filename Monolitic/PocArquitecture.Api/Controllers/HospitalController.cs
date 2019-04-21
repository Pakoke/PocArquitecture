namespace PocArquitecture.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PocArquitecture.Api.Model;
    using PocArquitecture.Entities.BusinessLogic.Entities;
    using PocArquitecture.Interfaces.BusinessLogic;
    using PocArquitecture.Interfaces.BusinessLogic.Entities;
    using Swashbuckle.AspNetCore.Annotations;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="HospitalController" />
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        /// <summary>
        /// Defines the hospitalBusinessLogic
        /// </summary>
        internal readonly IHospitalBusinessLogic hospitalBusinessLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="HospitalController"/> class.
        /// </summary>
        /// <param name="hospitalBusinessLogic">The hospitalBusinessLogic<see cref="IHospitalBusinessLogic"/></param>
        public HospitalController(IHospitalBusinessLogic hospitalBusinessLogic)
        {
            this.hospitalBusinessLogic = hospitalBusinessLogic;
        }

        /// <summary>
        /// GET api/values
        /// </summary>
        /// <returns>The <see cref="ActionResult"/></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        /// <summary>
        /// POST api/values
        /// </summary>
        /// <param name="hospitalModel">The hospitalModel<see cref="CreateHospitalModel"/></param>
        /// <returns>The <see cref="IActionResult"/></returns>
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
                    Address = hospitalModel.address,
                    Code = hospitalModel.code,
                    Name = hospitalModel.name,
                    Phone = hospitalModel.phone
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
