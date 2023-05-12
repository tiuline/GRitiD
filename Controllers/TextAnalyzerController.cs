using Microsoft.AspNetCore.Mvc;

namespace GRitiD.Controllers
{
    [ApiController]
    [Route("api/TextAnalyzer")]
    public class TextAnalyzerController : ControllerBase
    {
        private readonly ILogger<TextAnalyzerController> _logger;

        public TextAnalyzerController(ILogger<TextAnalyzerController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Analyze([FromBody] string document)
        {
            return Ok();
        }
    }
}