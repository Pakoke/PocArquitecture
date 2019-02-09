using Microsoft.AspNetCore.Mvc;
using PocArquitecture.Entities.BusinessLogic.Entities;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.Persistance.Repositories;
using System.Threading.Tasks;

namespace PocArquitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        readonly IStaffBusinessLogic staffBusinessLogic;

        public StaffController(IStaffBusinessLogic appConfigurationRepository)
        {
            this.staffBusinessLogic = appConfigurationRepository;
        }

        // 
        /// <summary>
        /// POST api/values
        /// </summary>
        /// <param name="dni">The value<see cref="string"/></param>
        /// <param name="codHospital">The value<see cref="string"/></param>
        /// <param name="codDepartment">The value<see cref="string"/></param>
        [HttpPost]
        public void Post(string dni, string codHospital, string codDepartment)
        {
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