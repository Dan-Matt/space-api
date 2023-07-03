using System.Numerics;

namespace SpaceApi.Models
{
    public class PlanetDto
    {
        public string Name { get; internal set; }
        public string ImageUrl { get; internal set; }
        public double DistanceFromSun { get; internal set; }
        public int DistanceFromSunPower { get; internal set; }
        public double Mass { get; internal set; }
        public int MassPower { get; internal set; }
        public double Diameter { get; internal set; }
    }
}
