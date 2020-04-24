using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using HackerRank.Misc;

namespace HackerRank.Misc {
    class Advent {

        public static int DayOneFuelRequired(int mass) {
            return mass / 3 - 2;
        }

        public static void DayTwoAlarmOpCode(int[] intcode) {
            for (int i = 0; i < intcode.Length; i += 4) {
                if (i == 1) {
                    int val1 = intcode[i + 1];
                    int val2 = intcode[i + 2];
                    intcode[i + 3] = val1 + val2;
                } else if (i == 2) {
                    int val1 = intcode[i + 1];
                    int val2 = intcode[i + 2];
                    intcode[i + 3] = val1 * val2;
                } else if (i == 99) {
                    break;
                } else {

                }
            }
        }

        public static void DayThreeCircuitBoard(string[] wire1, string[] wire2) {
            Dictionary<string, bool> matrix = new Dictionary<string, bool>();

            // Wire one
            string origin = "0,0"; // x, y
            string temp = "";

            for (int i = 0; i < wire1.Length; i++) {
                string startCoordinates = (i == 0) ? origin : temp;

                string endCommand = wire1[i];
                               
                switch (endCommand[0]) {
                    case 'U':

                        break;
                }
            }
        }

        public static int DayFourGetCombinations(int start, int end) {
            int total = 0;
            for (int i = start; i <= end; i++) {
                if (IsAscendingAndContainsDouble(i)) {
                    total++;
                }
            }

            return total;
        }


        public static bool IsAscendingAndContainsDouble(int x) {
            // O(n) = log(n)
            bool containsDouble = false;
            bool isAscending = true;

            while (x > 0) {
                int currentMod = x % 10;
                int nextNumber = x / 10;
                int nextMod = nextNumber % 10;
                if (currentMod == nextMod) {
                    containsDouble = true;
                }

                if (currentMod < nextMod) {
                    isAscending = false;
                    break;
                }

                x /= 10;
            }

            return (containsDouble && isAscending) ? true : false;
        }

        public static void DayFiveMoreOpCodes(int[] intcode) {
            for (int i = 0; i < intcode.Length; i += 4) {
                int fullCode = intcode[i]; // e.g. "01099"
                int opcode = fullCode % 100; // Last two digits
                int parameterCodes = fullCode / 100; // First three digits including leading zeroes

                if (opcode == 99) {
                    break;
                }

                int firstParameterValue = (parameterCodes % 10 == 0) ? intcode[intcode[i + 1]] : intcode[i + 1];
                int secondParameterValue = (parameterCodes / 10 % 10 == 0) ? intcode[intcode[i + 2]] : intcode[i + 2];
                int thirdParameterIndex = (parameterCodes / 100 % 10 == 0) ? intcode[i + 3] : intcode[intcode[i + 3]];

                if (opcode == 1) {
                    intcode[thirdParameterIndex] = firstParameterValue + secondParameterValue;
                } else if (opcode == 2) {
                    intcode[thirdParameterIndex] = firstParameterValue * secondParameterValue;
                } else if (opcode == 3) {
                    int input = GetInput();
                    int parameter = intcode[i + 1];
                    intcode[parameter] = input;
                } else if (opcode == 4) {
                    Console.WriteLine(intcode[i + 1]);
                }
            }
        }
       
        public static int GetInput() {
            return new Random().Next(100);
        }

        // I am assuming that planets are (a) listed in order and (b) maximum of planet Z
        // Each input element is like "A)B"
        // For the sake of clean code, I am renaming "COM" to "="
        public static int DaySixOrbitMaps(string[] map) {
            int total = 1;
            Dictionary<char, CelestialNode> dict = new Dictionary<char, CelestialNode>();

            dict.Add('=', new CelestialNode('=', 0, null)); // Add sun, it has no orbits and no pointer

            for (int i = 0; i < map.Length; i++) {
                char orbitingPlanetName = map[i].Last();
                char staticBodyName = map[i].First();
                CelestialNode staticBody = dict[staticBodyName]; // By the rules it must exist so not checking for null
                CelestialNode newPlanet = new CelestialNode(orbitingPlanetName, staticBody.Orbits++, dict[staticBodyName]); // I'm beginnning to think the linked list was unnecessary
                dict.Add(orbitingPlanetName, newPlanet);
                total += staticBody.Orbits++;
            }
            
            return total;
        }

    }

    public class CelestialNode {
        public char Name { get; set; }
        public int Orbits { get; set; }
        public CelestialNode Next { get; set; }
        public CelestialNode(char name, int orbits, CelestialNode celestialNode) {
            Name = name;
            Orbits = orbits;
            Next = celestialNode;
        }
    }
}
