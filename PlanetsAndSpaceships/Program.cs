using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            var lastPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastPlanets);
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");
            var rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");
            Console.WriteLine($"planets: {String.Join(",", planetList)}");
            Console.WriteLine($"rocky planets: {String.Join(",", rockyPlanets)}");

            var spacecraft = new Dictionary<string, List<string>>();
            spacecraft.Add("Voyager1", new List<string> { "Jupiter", "Saturn", "Uranus", "Neptune" });

            foreach (var planet in planetList)
            {
                foreach ()
            }

        }
    }
}
