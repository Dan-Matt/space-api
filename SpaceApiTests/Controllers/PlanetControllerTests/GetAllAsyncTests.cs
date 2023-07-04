using AutoFixture;
using FluentAssertions;
using Moq;
using SpaceApi.Models;

namespace SpaceApiTests.Controllers.PlanetControllerTests
{
    public class GetAllAsyncTests : BasePlanetControllerTests
    {
        [Fact]
        public async void Should_Get_All_Async()
        {
            // Arrange
            var dummyPlanets = Fixture.CreateMany<PlanetDto>(3);

            MockPlanetService
                .Setup(x => x.GetAllAsync())
                .ReturnsAsync(dummyPlanets);

            // Act
            var actual = await PlanetController.GetAllAsync();

            // Assert
            actual.Should().BeEquivalentTo(dummyPlanets);
        }
    }
}
