using GRitiD.Servces.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GRitiD.Controllers
{
    [ApiController]
    [Route("api/TextAnalyzer")]
    public class TextAnalyzerController : ControllerBase
    {
        private readonly ITextAnalyzerService _textAnalyzerService;

        public TextAnalyzerController(ITextAnalyzerService textAnalyzerService)
        {
            _textAnalyzerService = textAnalyzerService;
        }

        [HttpPost]
        [Route("analyze")]
        public IActionResult Analyze([FromBody] string text)
        {
            return Ok(_textAnalyzerService.Analyze(text));
        }
    }
}