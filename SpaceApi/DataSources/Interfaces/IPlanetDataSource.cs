using SpaceApi.Models;

namespace SpaceApi.DataSources.Interfaces
{
    public interface IPlanetDataSource
    {
        Task<IEnumerable<PlanetDto>> GetAllAsync();
    }
}
