using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class CityRoutes {
        private Dictionary<string, City> cities = new Dictionary<string, City>();
        private Dictionary<string, Road> roads = new Dictionary<string, Road>();

        readonly City startCity = new City("Alpha");
        readonly Road startRoad = new Road("One");
        City currentCity;

        public CityRoutes() {
            startRoad.Start = startCity;
            startCity.AddRoad(startRoad);
            cities.Add("Alpha", startCity);
            roads.Add("One", startRoad);
            currentCity = startCity;
        }

        public void AddCity(string name) {
            City newCity = new City(name);
            cities.Add(name, newCity);
        }

        public void AddRoad(string name) {
            Road newRoad = new Road(name);
            roads.Add(name, newRoad);
        }

        public void AttachRoadStart(string cityKey, string roadKey) {
            if (roads.ContainsKey(roadKey) && cities.ContainsKey(cityKey)) {
                roads[roadKey].Start = cities[cityKey];
                cities[cityKey].AddRoad(roads[roadKey]);
            }
        }
        public void AttachRoadEnd(string cityKey, string roadKey) {
            if (roads.ContainsKey(roadKey) && cities.ContainsKey(cityKey)) {
                roads[roadKey].End = cities[cityKey];
                cities[cityKey].AddRoad(roads[roadKey]);
            }
        }

        public void ListCurrentCityRoadsAndDestinations() {
            foreach (Road road in currentCity.Roads) {
                Console.WriteLine(road.Name);

                if (road.End.Name != currentCity.Name) {
                    Console.WriteLine(road.End.Name);
                }

                if (road.Start.Name != currentCity.Name) {
                    Console.WriteLine(road.Start.Name);
                }
            }
        }

        public void TravelToAdjacentCity(string destinationCityKey) {
            // Check city exists
            if (cities.ContainsKey(destinationCityKey)) {
                // Check if a road exists between current and destination cities
                // By iterating through the current city's List<Road>
                foreach (Road road in currentCity.Roads) {
                    // As the current city's roads are already attached to it, we only need to find whether the other end is attached to the destination city
                    if (road.Start.Name == destinationCityKey || road.End.Name == destinationCityKey) {
                        // Then set currentCity to the new city
                        currentCity = cities[destinationCityKey];
                        break;
                    }
                }
            }
        }
    }

    public class City {
        public string Name { get; set; }
        public List<Road> Roads { get; set; }

        public City(string name) {
            Name = name;
        }

        public City(string name, List<Road> roads) {
            Name = name;
            Roads = roads;
        }

        public City() {

        }

        public void AddRoad(Road road) {
            Roads.Add(road);
        }
    }

    // Two way road
    public class Road {
        public string Name { get; set; }
        public City Start { get; set; }
        public City End { get; set; }

        public Road(string name) {
            Name = name;
        }

        public Road(string name, City start) {
            Name = name;
            Start = start;
        }

        public Road(string name, City start, City end) {
            Name = name;
            Start = start;
            End = end;
        }

        public Road() {

        }
    }
}
