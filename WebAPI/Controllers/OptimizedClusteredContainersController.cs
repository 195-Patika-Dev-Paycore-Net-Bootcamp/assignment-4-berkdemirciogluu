using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptimizedClusteredContainersController : ControllerBase
    {
        IContainerService _containerService; //To avoid instance generation process everytime,injection was implemented.

        public OptimizedClusteredContainersController(IContainerService containerService)
        {
            _containerService = containerService;
        }

        [HttpGet]
        public IActionResult GetOptimizedContainers(long vehicleId, int clusterNumber)
        {
            var result = _containerService.GetOptimizedContainers(vehicleId, clusterNumber);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
