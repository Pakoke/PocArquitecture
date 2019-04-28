using Microsoft.AspNetCore.Mvc;
using NServiceBus;
using PocArquitecture.Shared;
using System.Collections.Generic;

namespace PocArquitecture.WriteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IMessageSession messageSession;

        public ValuesController(IMessageSession messageSession)
        {
            this.messageSession = messageSession;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var message = new MyMessage();

            var sendOptions = new SendOptions();
            sendOptions.SetDestination("PocArquitecture.RequestHandler");
            var response = messageSession.Request<ReplyApiMessage>(message, sendOptions)
                .ConfigureAwait(false);

            return response.GetAwaiter().GetResult().Guid;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
