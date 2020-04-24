using System;
using System.Collections.Generic;
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

        public static int GetCombinations(int start, int end) {
            int total = 0;
            for (int i = start; i <= end; i++) {
                if (IsAscendingAndContainsDouble(i)) {
                    total++;
                }
            }

            return total;
        }


        public static bool IsAscendingAndContainsDouble(int x) {
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

    }
}
