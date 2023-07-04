namespace SpaceApi.Models
{
    public class PlanetDto
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double DistanceFromSun { get; set; }
        public int DistanceFromSunPower { get; set; }
        public double Mass { get; set; }
        public int MassPower { get; set; }
        public double Diameter { get; set; }
    }
}
