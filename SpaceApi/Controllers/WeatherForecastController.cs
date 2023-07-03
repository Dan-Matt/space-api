using Microsoft.AspNetCore.Mvc;
using SpaceApi.Models;
using SpaceApi.Services.Interfaces;

namespace SpaceApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanetController : ControllerBase
    {
        private readonly ILogger<PlanetController> _logger;
        private readonly IPlanetService _planetService;

        public PlanetController(
            ILogger<PlanetController> logger,
            IPlanetService planetService)
        {
            _logger = logger;
            _planetService = planetService;
        }

        [HttpGet(Name = "GetPlanets")]
        public async Task<IEnumerable<PlanetDto>> GetAllAsync()
        {
            //_logger.Log("Getting all planets");
            return await _planetService.GetAllAsync();
        }
    }
}