using Microsoft.AspNetCore.Mvc;
using PocArquitecture.Interfaces.BusinessLogic;

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
    }
}