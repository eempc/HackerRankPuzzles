using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class CityRoutes {
        Dictionary<string, City> cities = new Dictionary<string, City>();
        Dictionary<string, Road> roads = new Dictionary<string, Road>();

        City startCity = new City("Alpha");
        Road startRoad = new Road("One");
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
            // Check city has been added
            if (cities.ContainsKey(destinationCityKey)) {
                // Check if the destination city has a road to it from the current city
                foreach (Road road in currentCity.Roads) {
                    if (road.End.Name == destinationCityKey || road.Start.Name == destinationCityKey) {
                        // Then set currentCity to the new city
                        currentCity = cities[destinationCityKey];
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
