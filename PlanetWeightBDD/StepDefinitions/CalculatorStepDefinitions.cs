using NUnit.Framework;
using PlanetWeights;
using TechTalk.SpecFlow;

namespace PlanetWeightBDD.StepDefinitions
{
    [Binding]
    public class WeightCalculationSteps
    {
        private WeightCalculator? weightCalculator; 
        private double result;
        private string currentPlanet = "Earth"; // Default initialization

        [Given(@"I weigh '(.*)' kilograms on Earth")]
        public void GivenIWeighKilogramsOnEarth(double weightOnEarth)
        {
            weightCalculator = new WeightCalculator();
            result = weightCalculator.CalculateWeightOnPlanet(weightOnEarth, currentPlanet);
        }

        [When(@"I calculate my weight on (.*)")]
        public void WhenICalculateMyWeightOnPlanet(string planet)
        {
            if (weightCalculator == null)
                throw new InvalidOperationException("WeightCalculator is not initialized.");

            currentPlanet = planet;
            result = weightCalculator.CalculateWeightOnPlanet(result, currentPlanet);
        }

        [Then(@"my weight on (.*) should be '(.*)' kilograms")]
        public void ThenMyWeightOnPlanetShouldBe(string planet, double expectedWeight)
        {
            Assert.AreEqual(expectedWeight, result, 0.01); // Precision for floating-point comparison
        }
    }
}
