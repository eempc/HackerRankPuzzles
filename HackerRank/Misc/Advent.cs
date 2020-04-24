using System;
using System.Collections.Generic;
using System.Text;

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

        public static void DayThreeCircuitBoard() {

        }

    }
}
