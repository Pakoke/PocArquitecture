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
    /// Defines the <see cref="DepartmentController" />
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        /// <summary>
        /// Defines the departmentBusinessLogic
        /// </summary>
        internal readonly IDepartmentBusinessLogic departmentBusinessLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentController"/> class.
        /// </summary>
        /// <param name="deparmentBusinessLogic">The deparmentBusinessLogic<see cref="IDepartmentBusinessLogic"/></param>
        public DepartmentController(IDepartmentBusinessLogic deparmentBusinessLogic)
        {
            this.departmentBusinessLogic = deparmentBusinessLogic;
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
        /// <param name="departmentModel">The departmentModel<see cref="CreateDepartmentModel"/></param>
        /// <returns>The <see cref="IActionResult"/></returns>
        [HttpPost]
        [SwaggerResponse(statusCode: 200, description: "The Department is created", type: typeof(IEnumerable<StatusCodeResult>))]
        [SwaggerResponse(statusCode: 400, description: "User is not valid", type: typeof(IEnumerable<StatusCodeResult>))]
        [SwaggerResponse(statusCode: 404, description: "Request not valid", type: typeof(IEnumerable<StatusCodeResult>))]
        public IActionResult Post([FromBody] CreateDepartmentModel departmentModel)
        {
            if (ModelState.IsValid)
            {
                IResult result = null;
                IDepartment department = new Department()
                {
                    Center = new Hospital() { Code = departmentModel.hospitalcode },
                    Code = departmentModel.code,
                    Name = departmentModel.name,
                    TypeOfDepartment = departmentModel.typeofdeparment
                };

                result = this.departmentBusinessLogic.AddDeparment(department);

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
