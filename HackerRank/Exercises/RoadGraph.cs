using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class RoadGraph {
        // A graph is represented by a list of vertices (junctions) and a list of edges (roads)
        List<RoundaboutJunction> roundabouts = new List<RoundaboutJunction>();
        List<Road> roads = new List<Road>();

        public RoundaboutJunction startingJunction = new RoundaboutJunction("Alpha");
        Road startRoad = new Road("start");       

        public RoadGraph() {
            startRoad.EndJunction = new RoundaboutJunction("Bravo");
            roads.Add(startRoad);
            startingJunction.RoadList.Add(startRoad);
        }

        public void BuildNewRoad(RoundaboutJunction start, RoundaboutJunction end, string name) {
            Road newRoad = new Road(name);
            newRoad.StartJunction = start;
            newRoad.EndJunction = end;
            roads.Add(newRoad);
        }

    }

    public class RoundaboutJunction {
        public string Name { get; set; }
        public List<Road> RoadList = new List<Road>();

        public RoundaboutJunction(string name) {
            Name = name;
        }

        public RoundaboutJunction() {

        }

        // Roads can only be built from junctions
        public void AttachNewRoad(Road newRoad) {
            RoadList.Add(newRoad);
        }
    }

    public class Road {
        public string Name { get; set; }
        public RoundaboutJunction StartJunction { get; set; }
        public RoundaboutJunction EndJunction { get; set; }
        // bool isOneWay;

        public Road(string name) {
            Name = name;
        }
    }
}
