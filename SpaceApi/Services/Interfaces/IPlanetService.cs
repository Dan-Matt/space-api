using SpaceApi.Models;

namespace SpaceApi.Services.Interfaces
{
    public interface IPlanetService
    {
        Task<IEnumerable<PlanetDto>> GetAllAsync();
    }
}
