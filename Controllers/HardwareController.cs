using Microsoft.AspNetCore.Mvc;
using SnipeIt.Services;
using SnipeIt.Models;
using System.Threading.Tasks;

namespace SnipeIt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HardwareController : ControllerBase
    { 
        private readonly IHardwareService _hardwareService;

        public HardwareController(IHardwareService hardwareService)
        {
            _hardwareService = hardwareService;
        }

        // GET: /api/hardware/1758
        [HttpGet("{id}")]
        public Task<HardwareAsset> Get([FromRoute] int id)
        {
            return _hardwareService.GetHardware(id);
        }
    }
}
