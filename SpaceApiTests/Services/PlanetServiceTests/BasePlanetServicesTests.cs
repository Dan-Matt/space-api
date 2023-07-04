using Moq;
using AutoFixture;
using SpaceApi.Services;
using SpaceApi.DataSources.Interfaces;

namespace SpaceApiTests.Services.PlanetControllerTests
{
    public class BasePlanetServicesTests
    {
        protected PlanetService PlanetService { get; }
        protected Mock<IPlanetDataSource> MockPlanetDataSource { get; }

        protected Fixture Fixture = new Fixture();

        public BasePlanetServicesTests()
        {
            MockPlanetDataSource = new Mock<IPlanetDataSource>();

            PlanetService = new PlanetService(MockPlanetDataSource.Object);
        }
    }
}
