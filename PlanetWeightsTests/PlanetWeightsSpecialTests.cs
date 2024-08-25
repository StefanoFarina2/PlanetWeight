using Xunit;
using PlanetWeights;

namespace PlanetWeightsTests
{
    public class PlanetWeightsSpecialTests
    {
        private PlanetWeight _planetWeight;

        public PlanetWeightsSpecialTests()
        {
            _planetWeight = new PlanetWeight();
        }

        [Fact]
        public void TestWeightOnMercury()
        {
            _planetWeight.weight = 75;
            _planetWeight.planet = Planets.mercury;

            double weightOnMercury = _planetWeight.weightOnPlanet;
            double expectedWeightOnMercury = 75 * 0.378;

            Assert.Equal(expectedWeightOnMercury, weightOnMercury, precision: 1);
        }

        [Fact]
        public void TestWeightOnVenus()
        {
            _planetWeight.weight = 75;
            _planetWeight.planet = Planets.venus;

            double weightOnVenus = _planetWeight.weightOnPlanet;
            double expectedWeightOnVenus = 75 * 0.907;

            Assert.Equal(expectedWeightOnVenus, weightOnVenus, precision: 1);
        }

        [Fact]
        public void TestWeightOnMoon()
        {
            _planetWeight.weight = 75;
            _planetWeight.planet = Planets.moon;

            double weightOnMoon = _planetWeight.weightOnPlanet;
            double expectedWeightOnMoon = 75 * 0.166;

            Assert.Equal(expectedWeightOnMoon, weightOnMoon, precision: 1);
        }

        [Fact]
        public void TestWeightOnMars()
        {
            _planetWeight.weight = 75;
            _planetWeight.planet = Planets.mars;

            double weightOnMars = _planetWeight.weightOnPlanet;
            double expectedWeightOnMars = 75 * 0.377;

            Assert.Equal(expectedWeightOnMars, weightOnMars, precision: 1);
        }

        [Fact]
        public void TestWeightOnJupiter()
        {
            _planetWeight.weight = 75;
            _planetWeight.planet = Planets.jupiter;

            double weightOnJupiter = _planetWeight.weightOnPlanet;
            double expectedWeightOnJupiter = 75 * 2.36;

            Assert.Equal(expectedWeightOnJupiter, weightOnJupiter, precision: 1);
        }

        [Fact]
        public void TestWeightOnSaturn()
        {
            _planetWeight.weight = 75;
            _planetWeight.planet = Planets.saturn;

            double weightOnSaturn = _planetWeight.weightOnPlanet;
            double expectedWeightOnSaturn = 75 * 0.916;

            Assert.Equal(expectedWeightOnSaturn, weightOnSaturn, precision: 1);
        }

        [Fact]
        public void TestWeightOnUranus()
        {
            _planetWeight.weight = 75;
            _planetWeight.planet = Planets.uranus;

            double weightOnUranus = _planetWeight.weightOnPlanet;
            double expectedWeightOnUranus = 75 * 0.889;

            Assert.Equal(expectedWeightOnUranus, weightOnUranus, precision: 1);
        }

        [Fact]
        public void TestWeightOnNeptune()
        {
            _planetWeight.weight = 75;
            _planetWeight.planet = Planets.neptune;

            double weightOnNeptune = _planetWeight.weightOnPlanet;
            double expectedWeightOnNeptune = 75 * 1.12;

            Assert.Equal(expectedWeightOnNeptune, weightOnNeptune, precision: 1);
        }

        [Fact]
        public void TestWeightOnPluto()
        {
            _planetWeight.weight = 75;
            _planetWeight.planet = Planets.pluto;

            double weightOnPluto = _planetWeight.weightOnPlanet;
            double expectedWeightOnPluto = 75 * 0.071;

            Assert.Equal(expectedWeightOnPluto, weightOnPluto, precision: 1);
        }
    }
}
