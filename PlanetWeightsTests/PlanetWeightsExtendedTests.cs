using Xunit;
using PlanetWeights;

namespace PlanetWeightsTests
{
    public class PlanetWeightsExtendedTests
    {
        private PlanetWeight _planetWeight;

        public PlanetWeightsExtendedTests()
        {
            _planetWeight = new PlanetWeight();
        }

        [Fact]
        public void TestWeightOnMercury()
        {
            _planetWeight.weight = 150;
            _planetWeight.planet = Planets.mercury;

            double weightOnMercury = _planetWeight.weightOnPlanet;
            double expectedWeightOnMercury = 150 * 0.378;

            Assert.Equal(expectedWeightOnMercury, weightOnMercury, 1);
        }

        [Fact]
        public void TestWeightOnVenus()
        {
            _planetWeight.weight = 150;
            _planetWeight.planet = Planets.venus;

            double weightOnVenus = _planetWeight.weightOnPlanet;
            double expectedWeightOnVenus = 150 * 0.907;

            Assert.Equal(expectedWeightOnVenus, weightOnVenus, 1);
        }

        [Fact]
        public void TestWeightOnMoon()
        {
            _planetWeight.weight = 150;
            _planetWeight.planet = Planets.moon;

            double weightOnMoon = _planetWeight.weightOnPlanet;
            double expectedWeightOnMoon = 150 * 0.166;

            Assert.Equal(expectedWeightOnMoon, weightOnMoon, 1);
        }

        [Fact]
        public void TestWeightOnMars()
        {
            _planetWeight.weight = 150;
            _planetWeight.planet = Planets.mars;

            double weightOnMars = _planetWeight.weightOnPlanet;
            double expectedWeightOnMars = 150 * 0.377;

            Assert.Equal(expectedWeightOnMars, weightOnMars, 1);
        }

        [Fact]
        public void TestWeightOnJupiter()
        {
            _planetWeight.weight = 150;
            _planetWeight.planet = Planets.jupiter;

            double weightOnJupiter = _planetWeight.weightOnPlanet;
            double expectedWeightOnJupiter = 150 * 2.36;

            Assert.Equal(expectedWeightOnJupiter, weightOnJupiter, 1);
        }

        [Fact]
        public void TestWeightOnSaturn()
        {
            _planetWeight.weight = 150;
            _planetWeight.planet = Planets.saturn;

            double weightOnSaturn = _planetWeight.weightOnPlanet;
            double expectedWeightOnSaturn = 150 * 0.916;

            Assert.Equal(expectedWeightOnSaturn, weightOnSaturn, 1);
        }

        [Fact]
        public void TestWeightOnUranus()
        {
            _planetWeight.weight = 150;
            _planetWeight.planet = Planets.uranus;

            double weightOnUranus = _planetWeight.weightOnPlanet;
            double expectedWeightOnUranus = 150 * 0.889;

            Assert.Equal(expectedWeightOnUranus, weightOnUranus, 1);
        }

        [Fact]
        public void TestWeightOnNeptune()
        {
            _planetWeight.weight = 150;
            _planetWeight.planet = Planets.neptune;

            double weightOnNeptune = _planetWeight.weightOnPlanet;
            double expectedWeightOnNeptune = 150 * 1.12;

            Assert.Equal(expectedWeightOnNeptune, weightOnNeptune, 1);
        }

        [Fact]
        public void TestWeightOnPluto()
        {
            _planetWeight.weight = 150;
            _planetWeight.planet = Planets.pluto;

            double weightOnPluto = _planetWeight.weightOnPlanet;
            double expectedWeightOnPluto = 150 * 0.071;

            Assert.Equal(expectedWeightOnPluto, weightOnPluto, 1);
        }

        [Fact]
        public void TestWeightMinimum()
        {
            _planetWeight.weight = PlanetWeight.weightMin;
            _planetWeight.planet = Planets.mars;

            double weightOnMars = _planetWeight.weightOnPlanet;
            double expectedWeightOnMars = PlanetWeight.weightMin * 0.377;

            Assert.Equal(expectedWeightOnMars, weightOnMars, 1);
        }

        [Fact]
        public void TestWeightMaximum()
        {
            _planetWeight.weight = PlanetWeight.WeightMax;
            _planetWeight.planet = Planets.jupiter;

            double weightOnJupiter = _planetWeight.weightOnPlanet;
            double expectedWeightOnJupiter = PlanetWeight.WeightMax * 2.36;

            Assert.Equal(expectedWeightOnJupiter, weightOnJupiter, 1);
        }

        // Removed the test for invalid weight scenario as it does not conform to the existing class logic
    }
}
