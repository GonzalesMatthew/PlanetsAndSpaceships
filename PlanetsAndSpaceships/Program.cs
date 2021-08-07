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
            spacecraft.Add("MESSENGER", new List<string> { "Mercury" });
            spacecraft.Add("BepiColombo", new List<string> { "Mercury" });
            spacecraft.Add("Mariner 2", new List<string> { "Venus" });
            spacecraft.Add("Mars Express", new List<string> { "Mars" });
            spacecraft.Add("Phoenix", new List<string> { "Mars" });

            Console.WriteLine("The planets were visited by these spacecraft:");
            foreach (var planet in planetList)
            {
                var visitedBy = new List<string>();
                foreach (var craft in spacecraft)
                {
                    if ( craft.Value.Contains(planet))
                    {
                        visitedBy.Add(craft.Key);
                    }
                }
                if (visitedBy.Count > 0)
                {
                    Console.WriteLine($"{planet}: {String.Join(",", visitedBy)}");
                }
            }
        }
    }
}
