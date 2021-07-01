using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SnipeIt.Models;
using SnipeIt.Services;

namespace SnipeIt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HardwareController : ControllerBase
    { 
        private readonly ILogger<HardwareController> _logger;
        private readonly IHardwareService _service;

        public HardwareController(
            ILogger<HardwareController> logger,
            IHardwareService service
            )
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public HardwareAsset Get(int id)
        {
            return _service.GetHardware(id);
        }
    }
}
