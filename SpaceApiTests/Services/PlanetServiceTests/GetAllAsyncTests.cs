using AutoFixture;
using FluentAssertions;
using Moq;
using SpaceApi.Models;

namespace SpaceApiTests.Services.PlanetControllerTests
{
    public class GetAllAsyncTests : BasePlanetServicesTests
    {
        [Fact]
        public async void Should_Get_All_Async()
        {
            // Arrange
            var dummyPlanets = Fixture.CreateMany<PlanetDto>(3);

            MockPlanetDataSource
                .Setup(x => x.GetAllAsync())
                .ReturnsAsync(dummyPlanets);

            // Act
            var actual = await PlanetService.GetAllAsync();

            // Assert
            actual.Should().BeEquivalentTo(dummyPlanets);
        }
    }
}
