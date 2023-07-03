using SpaceApi.DataSources.Interfaces;
using SpaceApi.Models;
using SpaceApi.Services.Interfaces;

namespace SpaceApi.Services
{
    public class PlanetService : IPlanetService
    {
        private IPlanetDataSource _planetDataSource;

        public PlanetService(IPlanetDataSource planetDataSource)
        {
            _planetDataSource = planetDataSource;
        }

        public async Task<IEnumerable<PlanetDto>> GetAllAsync()
        {
            return await _planetDataSource.GetAllAsync();
        }
    }
}
