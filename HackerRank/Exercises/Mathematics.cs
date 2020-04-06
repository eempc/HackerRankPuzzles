using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Exercises {
    class Mathematics {
        static int Handshakes(int n) {
            // triangle numbers
            return (n * (n - 1)) / 2;
        }

        static int lowestTriangle(int b, int area) {
            double a = Convert.ToDouble(area);
            double w = Convert.ToDouble(b);
            return Convert.ToInt32(Math.Ceiling((2 * a) / w));
        }

        static int maximumDraws(int n) {
            /*
             * Write your code here.
             */
            return n + 1;
        }

        static int[] findPoint(int px, int py, int qx, int qy) {
            // Three points in a straight line:
            // 1: Start = 0, 0
            // 2: Mid = 3, 3
            // 3: Reflection = 6, 6
            int[] result = new int[2];

            result[0] = qx - px + qx; // Simplified to (2 * qx - px)
            result[1] = qy - py + qy;

            return result;
        }

    }
}
