using System;
using System.Collections.Generic;

namespace PlanetWeightNewFeature
{
    public class AdvancedPlanetWeightCalculator
    {
        private double weight;

        public AdvancedPlanetWeightCalculator(double weight)
        {
            this.weight = weight;
        }

        public double CalculateWeightOnPlanet(double gravityFactor)
        {
            return weight * gravityFactor;
        }

        public Dictionary<string, double> CalculateWeights(Dictionary<string, double> gravityFactors)
        {
            var result = new Dictionary<string, double>();
            foreach (var planet in gravityFactors)
            {
                result[planet.Key] = CalculateWeightOnPlanet(planet.Value);
            }
            return result;
        }
    }
}
