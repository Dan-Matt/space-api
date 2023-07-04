using Moq;
using SpaceApi.Services.Interfaces;
using SpaceApi.Controllers;
using Microsoft.Extensions.Logging;
using AutoFixture;

namespace SpaceApiTests.Controllers.PlanetControllerTests
{
    public class BasePlanetControllerTests
    {
        protected PlanetController PlanetController { get; }
        protected Mock<ILogger<PlanetController>> MockLogger { get; }
        protected Mock<IPlanetService> MockPlanetService { get; }

        protected Fixture Fixture = new Fixture();

        public BasePlanetControllerTests()
        {
            MockLogger = new Mock<ILogger<PlanetController>>();
            MockPlanetService = new Mock<IPlanetService>();

            PlanetController = new PlanetController(
                MockLogger.Object, MockPlanetService.Object);
        }
    }
}
