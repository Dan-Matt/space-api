using SpaceApi.Models;

namespace SpaceApi.DataSources.Interfaces
{
    public interface IPlanetDataSource
    {
        /// <summary>
        /// Get all planets
        /// </summary>
        /// <returns>All planets</returns>
        Task<IEnumerable<PlanetDto>> GetAllAsync();
    }
}
