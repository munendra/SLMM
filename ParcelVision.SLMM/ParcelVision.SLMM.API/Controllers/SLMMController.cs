using Microsoft.AspNetCore.Mvc;
using ParcelVision.SLMM.Dtos;
using ParcelVision.SLMM.Service;

namespace ParcelVision.SLMM.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SLMMController : ControllerBase
    {
        private readonly ILawnService _lawnService;
        public SLMMController(ILawnService lawnService)
        {
            _lawnService = lawnService;
        }

        [HttpPost]
        [Route("lawntask")]
        public IActionResult LawnTask(LawnRequestDto lawnRequest)
        {
            var updatedMowerMaching = _lawnService.Task(lawnRequest);
            return Ok(updatedMowerMaching);
        }


    }
}
