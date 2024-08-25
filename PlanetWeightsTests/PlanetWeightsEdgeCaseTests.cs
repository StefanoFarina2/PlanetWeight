using Xunit;
using PlanetWeights;

namespace PlanetWeightsTests
{
    public class PlanetWeightsEdgeCaseTests
    {
        private PlanetWeight _planetWeight;

        public PlanetWeightsEdgeCaseTests()
        {
            _planetWeight = new PlanetWeight();
        }

        [Fact]
        public void TestZeroWeight()
        {
            _planetWeight.weight = 0;
            _planetWeight.planet = Planets.mercury; // Changed from earth to mercury

            double weightOnMercury = _planetWeight.weightOnPlanet;
            Assert.Equal(0, weightOnMercury, 1); // Allowing 1 decimal place
        }

        [Fact]
        public void TestNegativeWeight()
        {
            _planetWeight.weight = -10;
            _planetWeight.planet = Planets.mercury; // Changed from earth to mercury

            double weightOnMercury = _planetWeight.weightOnPlanet;
            double expectedWeightOnMercury = -10 * 0.378; // Gravity for mercury

            // Use Assert.Equal with a tolerance for floating-point comparisons
            Assert.Equal(expectedWeightOnMercury, weightOnMercury, precision: 1);
        }

        [Fact]
        public void TestWeightOnPluto()
        {
            _planetWeight.weight = 75;
            _planetWeight.planet = Planets.pluto;

            double weightOnPluto = _planetWeight.weightOnPlanet;
            double expectedWeightOnPluto = 75 * 0.071;

            // Use Assert.Equal with a tolerance for floating-point comparisons
            Assert.Equal(expectedWeightOnPluto, weightOnPluto, precision: 1);
        }
    }
}
