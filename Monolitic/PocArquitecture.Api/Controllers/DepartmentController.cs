using Microsoft.AspNetCore.Mvc;
using PocArquitecture.Interfaces.BusinessLogic;

namespace PocArquitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        readonly IDepartmentBusinessLogic deparmentBusinessLogic;

        public DepartmentController(IDepartmentBusinessLogic deparmentBusinessLogic)
        {
            this.deparmentBusinessLogic = deparmentBusinessLogic;
        }
    }
}