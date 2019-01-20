namespace PocArquitecture.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ValuesController" />
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // 
        /// <summary>
        /// GET api/values
        /// </summary>
        /// <returns>The <see cref="ActionResult{IEnumerable{string}}"/></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // 
        /// <summary>
        /// GET api/values/5
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="ActionResult{string}"/></returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // 
        /// <summary>
        /// POST api/values
        /// </summary>
        /// <param name="value">The value<see cref="string"/></param>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // 
        /// <summary>
        /// PUT api/values/5
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <param name="value">The value<see cref="string"/></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // 
        /// <summary>
        /// DELETE api/values/5
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
