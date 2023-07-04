using SpaceApi.Models;

namespace SpaceApi.Services.Interfaces
{
    public interface IPlanetService
    {
        /// <summary>
        /// Get all planets
        /// </summary>
        /// <returns>All planets</returns>
        Task<IEnumerable<PlanetDto>> GetAllAsync();
    }
}
