using Microsoft.AspNetCore.Mvc;
using Xunit_implementation.Service;

namespace Xunit_implementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;
        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        [HttpGet]
        [Route("add")]
        public int Add([FromQuery] int v1, [FromQuery] int v2) => _calculatorService.add(v1, v2);

        [HttpGet]
        [Route("subtract")]
        public int Subtract([FromQuery] int v1, [FromQuery] int v2) => _calculatorService.sub(v1, v2);

        [HttpGet]
        [Route("multiple")]
        public int Multiply([FromQuery] int v1, [FromQuery] int v2) => _calculatorService.mul(v1, v2);
                
    }
}
