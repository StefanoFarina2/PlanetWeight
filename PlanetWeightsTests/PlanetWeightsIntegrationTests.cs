using Xunit;
using PlanetWeights;

namespace PlanetWeightsTests
{
    public class PlanetWeightsIntegrationTests
    {
        private PlanetWeight _planetWeight;

        public PlanetWeightsIntegrationTests()
        {
            _planetWeight = new PlanetWeight();
        }

        [Fact]
        public void TestWeightCalculationIntegration()
        {
            _planetWeight.weight = 60;
            _planetWeight.planet = Planets.venus;

            double weightOnVenus = _planetWeight.weightOnPlanet;
            double expectedWeightOnVenus = 60 * 0.907;

            Assert.Equal(expectedWeightOnVenus, weightOnVenus, 1);
        }
    }
}
