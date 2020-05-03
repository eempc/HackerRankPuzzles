using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class RoadGraph {
        // A graph is represented by a list of vertices (junctions) and a list of edges (roads)
        List<RoundaboutJunction> roundabouts = new List<RoundaboutJunction>();
        List<Route> routes = new List<Route>();

        public RoundaboutJunction startingJunction = new RoundaboutJunction("Alpha");
        Route firstRoute = new Route("Start Street");

        public RoadGraph() {
            firstRoute.StartJunction = startingJunction;
            firstRoute.EndJunction = new RoundaboutJunction("Bravo");
            routes.Add(firstRoute);
            startingJunction.AttachNewRoad(firstRoute);
            roundabouts.Add(startingJunction);
        }

        public void BuildNewRoad(RoundaboutJunction start, RoundaboutJunction end, string name) {
            Route newRoad = new Route(name);
            newRoad.StartJunction = start;
            newRoad.EndJunction = end;
            routes.Add(newRoad);
        }

    }

    public class RoundaboutJunction {
        public string Name { get; set; }
        public List<Route> RouteList = new List<Route>();

        public RoundaboutJunction(string name) {
            Name = name;
        }

        // Roads can only be built from junctions
        public void AttachNewRoad(Route newRoute) {
            RouteList.Add(newRoute);
        }
    }

    public class Route {
        public string Name { get; set; }
        public RoundaboutJunction StartJunction { get; set; }
        public RoundaboutJunction EndJunction { get; set; }
        // bool isOneWay;

        public Route(string name) {
            Name = name;
        }
    }
}
