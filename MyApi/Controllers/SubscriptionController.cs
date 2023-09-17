using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private readonly ILogger<SubscriptionController> _logger;

        public SubscriptionController(ILogger<SubscriptionController> logger)
        {
            _logger = logger;
        }

        //retrieve full list of sub
        [HttpGet("/subs")]
        public IActionResult Get()
        {

            return Ok();
        }

        //retrieve single sub
        [HttpGet("/subs/{subName}")]
        public IActionResult Get(string subName)
        {
            if (subName is not null)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        //add sub
        [HttpPost("/subs")]
        public IActionResult Add([FromBody] Subscription subscription)
        {
            return Ok();
        }

        //edit sub
        [HttpPut("/subs/update")]
        public IActionResult Update([FromBody] Subscription subscription)
        {
            return Ok();
        }

        //delete sub
        [HttpDelete("subs/update")]
        public IActionResult Delete([FromBody] Subscription subscription)
        {
            return Ok();
        }
    }
}
