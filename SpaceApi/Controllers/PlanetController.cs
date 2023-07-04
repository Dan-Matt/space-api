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

        /// <summary>
        /// Get all planets
        /// </summary>
        /// <returns>All planets</returns>
        [HttpGet(Name = "GetPlanets")]
        public async Task<IEnumerable<PlanetDto>> GetAllAsync()
        {
            _logger.Log(LogLevel.Information, "Getting all planets");

            List<PlanetDto> planets = (await _planetService.GetAllAsync()).ToList();
            
            _logger.Log(LogLevel.Information, "Retrieved {count} planets", planets.Count);
            
            return planets;
        }
    }
}