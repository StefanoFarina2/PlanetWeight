using Xunit;
using PlanetWeights;

namespace PlanetWeightsTests
{
    public class PlanetWeightsBoundaryTests
    {
        private PlanetWeight _planetWeight;

        public PlanetWeightsBoundaryTests()
        {
            _planetWeight = new PlanetWeight();
        }

        [Fact]
        public void TestMinimumWeightOnMercury()
        {
            _planetWeight.weight = PlanetWeight.weightMin;
            _planetWeight.planet = Planets.mercury;

            double weightOnMercury = _planetWeight.weightOnPlanet;
            double expectedWeightOnMercury = PlanetWeight.weightMin * 0.378;

            Assert.Equal(expectedWeightOnMercury, weightOnMercury, precision: 1);
        }

        [Fact]
        public void TestMinimumWeightOnVenus()
        {
            _planetWeight.weight = PlanetWeight.weightMin;
            _planetWeight.planet = Planets.venus;

            double weightOnVenus = _planetWeight.weightOnPlanet;
            double expectedWeightOnVenus = PlanetWeight.weightMin * 0.907;

            Assert.Equal(expectedWeightOnVenus, weightOnVenus, precision: 1);
        }

        [Fact]
        public void TestMinimumWeightOnMoon()
        {
            _planetWeight.weight = PlanetWeight.weightMin;
            _planetWeight.planet = Planets.moon;

            double weightOnMoon = _planetWeight.weightOnPlanet;
            double expectedWeightOnMoon = PlanetWeight.weightMin * 0.166;

            Assert.Equal(expectedWeightOnMoon, weightOnMoon, precision: 1);
        }

        [Fact]
        public void TestMinimumWeightOnMars()
        {
            _planetWeight.weight = PlanetWeight.weightMin;
            _planetWeight.planet = Planets.mars;

            double weightOnMars = _planetWeight.weightOnPlanet;
            double expectedWeightOnMars = PlanetWeight.weightMin * 0.377;

            Assert.Equal(expectedWeightOnMars, weightOnMars, precision: 1);
        }

        [Fact]
        public void TestMinimumWeightOnJupiter()
        {
            _planetWeight.weight = PlanetWeight.weightMin;
            _planetWeight.planet = Planets.jupiter;

            double weightOnJupiter = _planetWeight.weightOnPlanet;
            double expectedWeightOnJupiter = PlanetWeight.weightMin * 2.36;

            Assert.Equal(expectedWeightOnJupiter, weightOnJupiter, precision: 1);
        }

        [Fact]
        public void TestMinimumWeightOnSaturn()
        {
            _planetWeight.weight = PlanetWeight.weightMin;
            _planetWeight.planet = Planets.saturn;

            double weightOnSaturn = _planetWeight.weightOnPlanet;
            double expectedWeightOnSaturn = PlanetWeight.weightMin * 0.916;

            Assert.Equal(expectedWeightOnSaturn, weightOnSaturn, precision: 1);
        }

        [Fact]
        public void TestMinimumWeightOnUranus()
        {
            _planetWeight.weight = PlanetWeight.weightMin;
            _planetWeight.planet = Planets.uranus;

            double weightOnUranus = _planetWeight.weightOnPlanet;
            double expectedWeightOnUranus = PlanetWeight.weightMin * 0.889;

            Assert.Equal(expectedWeightOnUranus, weightOnUranus, precision: 1);
        }

        [Fact]
        public void TestMinimumWeightOnNeptune()
        {
            _planetWeight.weight = PlanetWeight.weightMin;
            _planetWeight.planet = Planets.neptune;

            double weightOnNeptune = _planetWeight.weightOnPlanet;
            double expectedWeightOnNeptune = PlanetWeight.weightMin * 1.12;

            Assert.Equal(expectedWeightOnNeptune, weightOnNeptune, precision: 1);
        }

        [Fact]
        public void TestMinimumWeightOnPluto()
        {
            _planetWeight.weight = PlanetWeight.weightMin;
            _planetWeight.planet = Planets.pluto;

            double weightOnPluto = _planetWeight.weightOnPlanet;
            double expectedWeightOnPluto = PlanetWeight.weightMin * 0.071;

            Assert.Equal(expectedWeightOnPluto, weightOnPluto, precision: 1);
        }

        [Fact]
        public void TestMaximumWeightOnMercury()
        {
            _planetWeight.weight = PlanetWeight.WeightMax;
            _planetWeight.planet = Planets.mercury;

            double weightOnMercury = _planetWeight.weightOnPlanet;
            double expectedWeightOnMercury = PlanetWeight.WeightMax * 0.378;

            Assert.Equal(expectedWeightOnMercury, weightOnMercury, precision: 1);
        }

        [Fact]
        public void TestMaximumWeightOnVenus()
        {
            _planetWeight.weight = PlanetWeight.WeightMax;
            _planetWeight.planet = Planets.venus;

            double weightOnVenus = _planetWeight.weightOnPlanet;
            double expectedWeightOnVenus = PlanetWeight.WeightMax * 0.907;

            Assert.Equal(expectedWeightOnVenus, weightOnVenus, precision: 1);
        }

        [Fact]
        public void TestMaximumWeightOnMoon()
        {
            _planetWeight.weight = PlanetWeight.WeightMax;
            _planetWeight.planet = Planets.moon;

            double weightOnMoon = _planetWeight.weightOnPlanet;
            double expectedWeightOnMoon = PlanetWeight.WeightMax * 0.166;

            Assert.Equal(expectedWeightOnMoon, weightOnMoon, precision: 1);
        }

        [Fact]
        public void TestMaximumWeightOnMars()
        {
            _planetWeight.weight = PlanetWeight.WeightMax;
            _planetWeight.planet = Planets.mars;

            double weightOnMars = _planetWeight.weightOnPlanet;
            double expectedWeightOnMars = PlanetWeight.WeightMax * 0.377;

            Assert.Equal(expectedWeightOnMars, weightOnMars, precision: 1);
        }

        [Fact]
        public void TestMaximumWeightOnJupiter()
        {
            _planetWeight.weight = PlanetWeight.WeightMax;
            _planetWeight.planet = Planets.jupiter;

            double weightOnJupiter = _planetWeight.weightOnPlanet;
            double expectedWeightOnJupiter = PlanetWeight.WeightMax * 2.36;

            Assert.Equal(expectedWeightOnJupiter, weightOnJupiter, precision: 1);
        }

        [Fact]
        public void TestMaximumWeightOnSaturn()
        {
            _planetWeight.weight = PlanetWeight.WeightMax;
            _planetWeight.planet = Planets.saturn;

            double weightOnSaturn = _planetWeight.weightOnPlanet;
            double expectedWeightOnSaturn = PlanetWeight.WeightMax * 0.916;

            Assert.Equal(expectedWeightOnSaturn, weightOnSaturn, precision: 1);
        }

        [Fact]
        public void TestMaximumWeightOnUranus()
        {
            _planetWeight.weight = PlanetWeight.WeightMax;
            _planetWeight.planet = Planets.uranus;

            double weightOnUranus = _planetWeight.weightOnPlanet;
            double expectedWeightOnUranus = PlanetWeight.WeightMax * 0.889;

            Assert.Equal(expectedWeightOnUranus, weightOnUranus, precision: 1);
        }

        [Fact]
        public void TestMaximumWeightOnNeptune()
        {
            _planetWeight.weight = PlanetWeight.WeightMax;
            _planetWeight.planet = Planets.neptune;

            double weightOnNeptune = _planetWeight.weightOnPlanet;
            double expectedWeightOnNeptune = PlanetWeight.WeightMax * 1.12;

            Assert.Equal(expectedWeightOnNeptune, weightOnNeptune, precision: 1);
        }

        [Fact]
        public void TestMaximumWeightOnPluto()
        {
            _planetWeight.weight = PlanetWeight.WeightMax;
            _planetWeight.planet = Planets.pluto;

            double weightOnPluto = _planetWeight.weightOnPlanet;
            double expectedWeightOnPluto = PlanetWeight.WeightMax * 0.071;

            Assert.Equal(expectedWeightOnPluto, weightOnPluto, precision: 1);
        }
    }
}
