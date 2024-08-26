using Xunit;
using PlanetWeightNewFeature;

namespace PlanetWeightNewFeature.Tests.Unit
{
    public class AdvancedPlanetWeightCalculatorTests
    {
        [Fact]
        public void TestWeightOnMercury()
        {
            double weight = 150;
            double result = AdvancedPlanetWeightCalculator.CalculateWeight(weight, "mercury");
            Assert.Equal(150 * 0.378, result, 1);
        }

        [Fact]
        public void TestWeightOnVenus()
        {
            double weight = 150;
            double result = AdvancedPlanetWeightCalculator.CalculateWeight(weight, "venus");
            Assert.Equal(150 * 0.907, result, 1);
        }

        [Fact]
        public void TestWeightOnUnknownPlanet()
        {
            double weight = 150;
            Assert.Throws<ArgumentException>(() => AdvancedPlanetWeightCalculator.CalculateWeight(weight, "unknown"));
        }
    }
}
