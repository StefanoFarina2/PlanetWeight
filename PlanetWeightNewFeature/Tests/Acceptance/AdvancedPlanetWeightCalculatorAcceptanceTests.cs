using Xunit;
using PlanetWeightNewFeature;

namespace PlanetWeightNewFeature.Tests.Acceptance
{
    public class AdvancedPlanetWeightCalculatorAcceptanceTests
    {
        [Fact]
        public void TestWeightCalculationForValidPlanets()
        {
            double weight = 150;

            string[] planets = { "mercury", "venus", "mars", "jupiter" };
            foreach (var planet in planets)
            {
                double result = AdvancedPlanetWeightCalculator.CalculateWeight(weight, planet);
                Assert.True(result > 0, $"Weight calculation failed for planet: {planet}");
            }
        }

        [Fact]
        public void TestWeightCalculationForInvalidPlanet()
        {
            double weight = 150;
            Assert.Throws<ArgumentException>(() => AdvancedPlanetWeightCalculator.CalculateWeight(weight, "unknown"));
        }
    }
}
