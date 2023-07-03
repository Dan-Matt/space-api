using Dapper;
using Npgsql;
using SpaceApi.DataSources.Interfaces;
using SpaceApi.Models;

namespace SpaceApi.DataSources
{
    public class PlanetDataSource : IPlanetDataSource
    {
        private string? _connectionString;

        public PlanetDataSource(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Postgres");
        }

        public async Task<IEnumerable<PlanetDto>> GetAllAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                var query =
                    @"SELECT 
                        name AS Name,
                        image_url AS ImageUrl,
                        distance_from_sun AS DistanceFromSun,
                        distance_from_sun_power AS DistanceFromSunPower,
                        mass AS Mass,
                        mass_power AS MassPower,
                        diameter AS Diameter
                      FROM 
                        space.planets";

                return await connection.QueryAsync<PlanetDto>(query);
            }
        }
    }
}
