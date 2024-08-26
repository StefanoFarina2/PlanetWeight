// PlanetWeight/WeightCalculator.cs
using System;
using System.Collections.Generic;

namespace PlanetWeights
{
    public class WeightCalculator
    {
        private static readonly Dictionary<string, double> PlanetGravities = new()
        {
            { "Earth", 1.0 },
            { "Mars", 0.377 },
            { "Jupiter", 2.364 }
        };

        public double CalculateWeightOnPlanet(double weightOnEarth, string planet)
        {
            if (!PlanetGravities.ContainsKey(planet))
                throw new ArgumentException($"Gravity for planet '{planet}' is not defined.");

            double gravity = PlanetGravities[planet];
            return weightOnEarth * gravity;
        }
    }
}
