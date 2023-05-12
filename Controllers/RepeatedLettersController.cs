using Microsoft.AspNetCore.Mvc;

namespace GRitiD.Controllers
{
    [ApiController]
    [Route("api/RepeatedLetters")]
    public class RepeatedLettersController : ControllerBase
    {
        private readonly ILogger<RepeatedLettersController> _logger;

        public RepeatedLettersController(ILogger<RepeatedLettersController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("repeatedLetters")]
        public IActionResult GetRepeatedLetters([FromBody] string text)
        {
            return Ok();
        }
    }
}